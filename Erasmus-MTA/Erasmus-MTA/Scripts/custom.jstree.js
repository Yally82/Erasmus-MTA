$(function () {

    $('#jstree').jstree({
        'plugins': ["wholerow", "checkbox"],
        'core': {
            'data': [{
                "text": "Tara",
                "state": {
                    "opened": true
                },
                "children": [{
                    "text": "Bulgaria",
                    "state": {

                        "selected": false
                    }
                }, {
                    "text": "Croatia",
                    "icon": "./assets/images/tree_icon.png"
                }, {
                    "text": "Grecia",
                    "icon": "./assets/images/tree_icon.png"
                },
                {
                    "text": "Croatia",
                    "icon": "./assets/images/tree_icon.png"
                }, {
                    "text": "Grecia",
                    "icon": "./assets/images/tree_icon.png"
                },
                {
                    "text": "Croatia",
                    "icon": "./assets/images/tree_icon.png"
                }, {
                    "text": "Grecia",
                    "icon": "./assets/images/tree_icon.png"
                },
                {
                    "text": "Croatia",
                    "icon": "./assets/images/tree_icon.png"
                }, {
                    "text": "Grecia",
                    "icon": "./assets/images/tree_icon.png"
                },
                {
                    "text": "Croatia",
                    "icon": "./assets/images/tree_icon.png"
                }, {
                    "text": "Grecia",
                    "icon": "./assets/images/tree_icon.png"
                }, {
                    "text": "Croatia",
                    "icon": "./assets/images/tree_icon.png"
                }, {
                    "text": "Grecia",
                    "icon": "./assets/images/tree_icon.png"
                }, {
                    "text": "Croatia",
                    "icon": "./assets/images/tree_icon.png"
                }, {
                    "text": "Grecia",
                    "icon": "./assets/images/tree_icon.png"
                }, {
                    "text": "Croatia",
                    "icon": "./assets/images/tree_icon.png"
                }, {
                    "text": "Grecia",
                    "icon": "./assets/images/tree_icon.png"
                }]
            },
            {
                "text": "Oras",
                "state": {
                    "opened": true
                },
                "children": [{
                    "text": "Bruxelles",
                    "state": {
                        "selected": false
                    }
                }, {
                    "text": "Veliko Tarnovo",
                    "icon": "./assets/images/tree_icon.png"
                }, {
                    "text": "Pardubice",
                    "icon": "./assets/images/tree_icon.png"
                }]
            },
            {
                "text": "Departamet",
                "state": {
                    "opened": true
                },
                "children": [{
                    "text": "Departamet1",
                    "state": {
                        "selected": false
                    }
                }, {
                    "text": "Departamet2",
                    "icon": "./assets/images/tree_icon.png"
                }, {
                    "text": "Departamet3",
                    "icon": "./assets/images/tree_icon.png"
                }]
            },
            {
                "text": "Gen",
                "state": {
                    "opened": true
                },
                "children": [{
                    "text": "Masculin",
                    "state": {
                        "selected": false
                    }
                }, {
                    "text": "Feminin",
                    "icon": "./assets/images/tree_icon.png"
                }]
            },
            {
                "text": "Partener",
                "state": {
                    "opened": true
                },
                "children": [{
                    "text": "Partener1",
                    "state": {
                        "selected": false
                    }
                }, {
                    "text": "Partener2",
                    "icon": "./assets/images/tree_icon.png"
                }]
            },
            {
                "text": "Tip parteneri",
                "state": {
                    "opened": true
                },
                "children": [{
                    "text": "Universitate militara",
                    "state": {
                        "selected": false
                    }
                }, {
                    "text": "Universitate civila",
                    "icon": "./assets/images/tree_icon.png"
                }]
            },
            {
                "text": "Nivel mobilitate",
                "state": {
                    "opened": true
                },
                "children": [{
                    "text": "1",
                    "state": {
                        "selected": false
                    }
                }, {
                    "text": "Partener2",
                    "icon": "./assets/images/tree_icon.png"
                }]
            }
            ],
            'themes': {
                'name': 'proton',
                'responsive': true,
                'icons': false
            }

        }
    });


});