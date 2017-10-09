
$("#backFromModalMobilitate").click(function () {
 $('#myModalParticipant').show();
   $('#myModalMobilitate').hide();

});


$("#jsGrids").jsGrid({
    width: "100%",
    height: "750px",

    autoload: true,
    filtering: true,
    inserting: true,
    selecting: true,
    editing: true,
    sorting: true,
    paging: true,
    pageSize: 15,


    deleteConfirm: "Do you really want to delete the client?",

    controller: {
        loadData: function (filter) {
            var data = $.Deferred();
            $.ajax({
                type: "GET",
                contentType: "application/json",
                url: "/Mobilities/Intern/getjson/StudentMobilities"
            }).done(function (response) {
                data.resolve(response);
            });
            return data.promise();
        }
    },

    fields: [
        { name: "ID", type: "number", width: 70, validate: "required" },
        { name: "Year", type: "number", width: 70, validate: "required" },
        { name: "TipMobilitate", type: "text" },
        { name: "Nivel", type: "text"},
        { name: "NumeSiPrenume", type: "text", width: 150, validate: "required" },
        {
            type: "control", width: 150,
            itemTemplate: function (value, item) {
                var $result = jsGrid.fields.control.prototype.itemTemplate.apply(this, arguments);

                var $customButton = $("<button>")
                    .text("Detalii")

                    .click(function (e) {
                        $('#myModalMobilitate').hide();
                        $('#myModal').modal('show');
                        $('#myModalParticipant').show();
                        e.stopPropagation();
                    });

                return $result.add($customButton);
            }
        }
    ]
});
App = {};

App.loadUrl = "/Mobilities/Intern/getjson/PersonalATMMobilities";

$("#jsGridp").jsGrid({
    width: "100%",
    height: "750px",

    autoload: true,
    filtering: true,
    inserting: true,
    editing: true,
    sorting: true,
    paging: true,
    pagesize: 15,


    deleteconfirm: "do you really want to delete the client?",
    controller: {
        loadData: function (filter) {
            var data = $.Deferred();
            $.ajax({
                type: "GET",
                contentType: "application/json",
                url:App.loadUrl
            }).done(function (response) {
                data.resolve(response);
            });
            return data.promise();
        }
    },


    fields: [
        { name: "ID", type: "number", width: 70, validate: "required" },
        { name: "Year", type: "number", width: 70, validate: "required" },
        { name: "TipMobilitate", type: "text" },
        {name: "Nivel",type:",text", width: 70, validate: "required" },
        { name: "NumeSiPrenume", type: "text", width: 150, validate: "required" },
        {
            type: "control", width: 150,
            itemtemplate: function (value, item) {
                var $result = jsgrid.fields.control.prototype.itemtemplate.apply(this, arguments);

                var $custombutton = $("<button>")
                    .text("detalii")
                    .click(function (e) {
                        $('#mymodal').modal('show');
                        $('#mymodalmobilitate').hide();
                        $('#mymodalparticipant').show();
                        e.stoppropagation();
                    });

                return $result.add($custombutton);
            }
        }
    ]
});
 $('#jstree').on('changed.jstree', function (e, data) {
        var i, j,r=[], tara = [],oras=[],departament=[],parteneri=[],nivelStudii=[],tipPartener=[],nivelMobilitate=[];
        for (i = 0, j = data.selected.length; i < j; i++) {
            r.push(data.instance.get_node(data.instance.get_parent(data.selected[i])).text);
            switch(data.instance.get_node(data.instance.get_parent(data.selected[i])).text)
            {
                case "Tara":
                    {
                        tara.push(data.instance.get_node(data.selected[i]).text);
                        break;
                    }
                case "Oras":
                    {
                        oras.push(data.instance.get_node(data.selected[i]).text);
                        break;
                    }
                case "Parteneri":
                    {
                        parteneri.push(data.instance.get_node(data.selected[i]).text);
                        break;
                    }
                case "NivelStudii":
                    {
                        nivelStudii.push(data.instance.get_node(data.selected[i]).text);
                        break;
                    }
                case "TipPartener":
                    {
                        tipPartener.push(data.instance.get_node(data.selected[i]).text);
                        break;
                    }
                case "NivelMobilitate":
                    {
                        nivelMobilitate.push(data.instance.get_node(data.selected[i]).text);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
        App.loadUrl = "/Mobilities/Intern/getjson/jstreeChecked"; 
        if (tara.length > 0 || oras.length > 0 || departament.length > 0 || parteneri.length > 0 || nivelStudii.length > 0 || tipPartener.length > 0 || nivelMobilitate.le > 0) {
            App.loadUrl = App.loadUrl.concat("?");
            if (tara.length > 0) {
                App.loadUrl = App.loadUrl.concat("tara=").concat(tara);
                App.loadUrl = App.loadUrl.concat("&");
            }
            if (oras.length > 0) {
                App.loadUrl = App.loadUrl.concat("&oras=").concat(oras);
                App.loadUrl = App.loadUrl.concat("&");
            }
            if (departament.length > 0) {
                App.loadUrl = App.loadUrl.concat("&departament=").concat(departament);
                App.loadUrl = App.loadUrl.concat("&");
            }
            if (parteneri.length > 0) {
                App.loadUrl = App.loadUrl.concat("&parteneri=").concat(parteneri);
                App.loadUrl = App.loadUrl.concat("&");
            }
            if (nivelStudii.length > 0) {
                App.loadUrl = App.loadUrl.concat("&nivelStudii=").concat(nivelStudii);
                App.loadUrl = App.loadUrl.concat("&");
            }
            if (tipPartener.length > 0) {
                App.loadUrl = App.loadUrl.concat("&tipPartener=").concat(tipPartener);
                App.loadUrl = App.loadUrl.concat("&");
            }
            if (nivelMobilitate.length > 0) {
                App.loadUrl = App.loadUrl.concat("&nivelMobilitate=").concat(nivelMobilitate);
                App.loadUrl = App.loadUrl.concat("&");
            }
          
            $("#jsGridp").jsGrid("loadData");
        }
    })


