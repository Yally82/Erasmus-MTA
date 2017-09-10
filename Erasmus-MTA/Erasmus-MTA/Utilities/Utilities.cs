using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Erasmus_MTA.Utilities
{
    public enum MobilityType
    {
        Incoming,
        Outgoing,
    }

    public class JstreeObject
    {
        public string text;
        public int id;
        public State state;
        public List<JstreeObject> children;

        public JstreeObject()
        {
            state = new State();
            state.opened = true;
            children = new List<JstreeObject>();
        }
        public JstreeObject(string name)
            : this()
        {
            text = name;
        }
        public void Add(JstreeObject obj)
        {
            children.Add(obj);
        }
    }
    public class State
    {
        public bool selected;
        public bool opened;
        public bool disabled;
    }


}