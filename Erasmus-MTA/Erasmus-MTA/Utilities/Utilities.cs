using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Security.Cryptography;

namespace Erasmus_MTA.Utilities
{
    public enum MobilityType
    {
        Incoming,
        Outgoing,
    }
    public class Utility{

        public static MethodInfo GetExtensionMethods(Assembly assembly, Type extendedType,string functionName)
        {
            foreach (Type t in assembly.GetTypes())
            {
                if (t.IsDefined(typeof(ExtensionAttribute), false))
                {
                    foreach (MethodInfo mi in t.GetMethods())
                    {
                        if (mi.IsDefined(typeof(ExtensionAttribute), false))
                        {
                            if (mi.GetParameters()[0].ParameterType == extendedType)
                                if(mi.Name.Contains(functionName))
                                    return mi;
                        }
                    }
                }
            }
            return null;
        }
    }


    public class JsonObject
    {
        public string text;
        public string icon;
        public string id;
        public State state;
        public List<JsonObject> children;

        public JsonObject()
        {
            state = new State();
            state.selected = false;
            children = new List<JsonObject>();
        }
        public JsonObject(string name)
            : this()
        {
            
            text = name;
        }
        public void Add(JsonObject obj/*,int parentId*/)
        {

            children.Add(obj);
        }
    }
    public class State
    {
        public bool selected;
        public bool opened;
    }

    public static class HashGenerator
    {
        public static string getHash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }
    }
}