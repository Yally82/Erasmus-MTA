//$(function () {
//    $('#jstree').jstree({
//        'plugins': ["wholerow","checkbox", ],
//        
//        'core': {
//            'data': {
//                "url": "/Mobilities/Intern/getjson",
//                "dataType": "json",
//                "type": "GET"
//            }
//        }
//       'themes': {
    //            'name': 'proton',
    //            'responsive': true,
    //            'icons': false
    //        }
        
//    });
//});

$(function () {

    $('#jstree').jstree({
        'plugins': ["wholerow", "checkbox"],
        'core': {
            'data': { 
                "url": "/Mobilities/Intern/getjson",
                "dataType": "json",
                "type": "GET"
                  },
            'themes': {
                'name': 'proton',
                'responsive': true,
                'icons': false
        }
       
    }
    });


});