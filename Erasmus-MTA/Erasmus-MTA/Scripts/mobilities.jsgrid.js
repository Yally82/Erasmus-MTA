$(document).ready(function () {

    $("#backFromModalMobilitate").click(function () {
        $('#myModalParticipant').show();
        $('#myModalMobilitate').hide();

    });

    App = {};

    App.loadUrlPersonal = "/Mobilities/Intern/getjson/PersonalATMMobilities";
    App.loadUrlStudents = "/Mobilities/Intern/getjson/StudentMobilities";

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
                    url: App.loadUrlStudents
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
            { name: "Nivel", type: "text" },
            { name: "NumeSiPrenume", type: "text", width: 150, validate: "required" },
            {
                type: "control", width: 150,
                itemTemplate: function (value, item) {
                    var $result = jsGrid.fields.control.prototype.itemTemplate.apply(this, arguments);

                    var $customButton = $("<button>")
                        .text("Detalii")

                        .click(function (e) {
                            //$('#myModalParticipant').hide();
                            $('#myModal').modal('show');
                            $('#myModalMobilitate').show();
                            populate(item);
                            e.stopPropagation();
                        });

                    return $result.add($customButton);
                }
            }
        ]
    });


    function GetDate(tdate) {
        str = tdate.replace(/\D/g, "");
        d = new Date(parseInt(str));

        year = d.getFullYear();
        month = pad(d.getMonth() + 1);
        day = pad(d.getDate());
        //hour = pad(d.getHours());
        //minutes = pad(d.getMinutes());

        finalDate = year + "-" + month + "-" + day;
        function pad(num) {
            num = "0" + num;
            return num.slice(-2);
        }
        return finalDate;
    }

    $("#jsGridp").jsGrid({
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



        deleteconfirm: "do you really want to delete the client?",
        controller: {
            loadData: function (filter) {
                var data = $.Deferred();
                $.ajax({
                    type: "GET",
                    contentType: "application/json",
                    url: App.loadUrlPersonal
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
            { name: "Nivel", type: ",text", width: 70, validate: "required" },
            { name: "NumeSiPrenume", type: "text", width: 150, validate: "required" },
            {
                type: "control", width: 150,
                itemTemplate: function (value, item) {
                    var $result = jsGrid.fields.control.prototype.itemTemplate.apply(this, arguments);

                    var $customButton = $("<button>")
                        .text("Detalii")

                        .click(function (e) {
                            //$('#myModalMobilitate').hide();
                            $('#myModal').modal('show');
                            $('#myModalParticipant').show();
                            populate(item);
                            e.stopPropagation();
                        });

                    return $result.add($customButton);
                }
            }
        ]
    });
    $('#jstree').bind('changed.jstree', function (e, data) {
        var i, j, tara = [], oras = [], departament = [], parteneri = [], nivelStudii = [], tipPartener = [], nivelMobilitate = [];

        var checked = $('#jstree').jstree("get_checked");
        for (i = 0, j = checked.length; i < j; i++) {

            switch (data.instance.get_node(data.instance.get_parent(checked[i])).text) {
                case "Tara":
                    {
                        tara.push(data.instance.get_node(checked[i]).text);
                        break;
                    }
                case "Oras":
                    {
                        oras.push(data.instance.get_node(data.selected[i]).text);
                        break;
                    }
                case "Departament":
                    {
                        departament.push(data.instance.get_node(data.selected[i]).text);
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

        if (tara.length > 0 || oras.length > 0 || departament.length > 0 || parteneri.length > 0 || nivelStudii.length > 0 || tipPartener.length > 0 || nivelMobilitate.le > 0) {
            App.loadUrlPersonal = "/Mobilities/Intern/getjson/jstreeCheckedPersonal";
            App.loadUrlPersonal = App.loadUrlPersonal.concat("?");
            App.loadUrlStudents = "/Mobilities/Intern/getjson/jstreeCheckedStudents";
            App.loadUrlStudents = App.loadUrlStudents.concat("?");
            if (tara.length > 0) {
                App.loadUrlPersonal = App.loadUrlPersonal.concat("tara=").concat(tara);
                App.loadUrlPersonal = App.loadUrlPersonal.concat("&");
                App.loadUrlStudents = App.loadUrlStudents.concat("tara=").concat(tara);
                App.loadUrlStudents = App.loadUrlStudents.concat("&");
            }
            if (oras.length > 0) {
                App.loadUrlPersonal = App.loadUrlPersonal.concat("&oras=").concat(oras);
                App.loadUrlPersonal = App.loadUrlPersonal.concat("&");
                App.loadUrlStudents = App.loadUrlStudents.concat("&oras=").concat(oras);
                App.loadUrlStudents = App.loadUrlStudents.concat("&");
            }
            if (departament.length > 0) {
                App.loadUrlPersonal = App.loadUrlPersonal.concat("&departament=").concat(departament);
                App.loadUrlPersonal = App.loadUrlPersonal.concat("&");
                App.loadUrlStudents = App.loadUrlStudents.concat("&departament=").concat(departament);
                App.loadUrlStudents = App.loadUrlStudents.concat("&");
            }
            if (parteneri.length > 0) {
                App.loadUrlPersonal = App.loadUrlPersonal.concat("&parteneri=").concat(parteneri);
                App.loadUrlPersonal = App.loadUrlPersonal.concat("&");
                App.loadUrlStudents = App.loadUrlStudents.concat("&parteneri=").concat(parteneri);
                App.loadUrlStudents = App.loadUrlStudents.concat("&");
            }
            if (nivelStudii.length > 0) {
                App.loadUrlPersonal = App.loadUrlPersonal.concat("&nivelStudii=").concat(nivelStudii);
                App.loadUrlPersonal = App.loadUrlPersonal.concat("&");
                App.loadUrlStudents = App.loadUrlStudents.concat("&nivelStudii=").concat(nivelStudii);
                App.loadUrlStudents = App.loadUrlStudents.concat("&");
            }
            if (tipPartener.length > 0) {
                App.loadUrlPersonal = App.loadUrlPersonal.concat("&tipPartener=").concat(tipPartener);
                App.loadUrlPersonal = App.loadUrlPersonal.concat("&");
                App.loadUrlStudents = App.loadUrlStudents.concat("&tipPartener=").concat(tipPartener);
                App.loadUrlStudents = App.loadUrlStudents.concat("&");
            }
            if (nivelMobilitate.length > 0) {
                App.loadUrlPersonal = App.loadUrlPersonal.concat("&nivelMobilitate=").concat(nivelMobilitate);
                App.loadUrlPersonal = App.loadUrlPersonal.concat("&");
                App.loadUrlStudents = App.loadUrlStudents.concat("&nivelMobilitate=").concat(nivelMobilitate);
                App.loadUrlStudents = App.loadUrlStudents.concat("&");
            }


        }
        else {
            App.loadUrlPersonal = "/Mobilities/Intern/getjson/PersonalATMMobilities";
            App.loadUrlStudents = "/Mobilities/Intern/getjson/StudentMobilities";
        }
        $("#jsGridp").jsGrid("loadData");
        $("#jsGrids").jsGrid("loadData");
    });


    function populate(item) {
        $('[name=nume]', '#myModalMobilitate').val(item.Nume);
        $('[name=prenume]', '#myModalMobilitate').val(item.Prenume);
        $('[name=anMobilitate]', '#myModalMobilitate').val(item.Year);
        $('[name=tipMobilitate]', '#myModalMobilitate').val(item.TipMobilitate);
        $('[name=institutiaGazda]', '#myModalMobilitate').val(item.institutiePartenera);
        $('[name=dataInceput]', '#myModalMobilitate').val(GetDate(item.DataInceputMobilitate));
        $('[name=dataFinal]', '#myModalMobilitate').val(GetDate(item.DataFinalMobilitate));
        $('[name=luniMobilitate]', '#myModalMobilitate').val(item.nrLuni);
        $('[name=zileMobilitate]', '#myModalMobilitate').val(item.nrZile);
        $('[name=grantMobilitate]', '#myModalMobilitate').val(item.GrantErasmusUtilizat);
        $('[name=nivelMobilitate]', '#myModalMobilitate').val(item.Nivel);

    }
});