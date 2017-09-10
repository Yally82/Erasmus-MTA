
switch ($("#tipTabel").text()) {
    case "Tari":
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
                        url: "/Tables/Intern/getjson/Tara"
                    }).done(function (response) {
                        data.resolve(response);
                    });
                    return data.promise();
                }
            },

            fields: [
                { name: "ID", type: "number", width: 70, validate: "required" },
                { name: "Nume", type: "text", width: 70, validate: "required" },
                { name: "NumeRomana", type: "text", width: 70, validate: "required" },
                { name: "NumeEngleza", type: "text", width: 70, validate: "required" }
            ]
        });

    break;
    case "Orase":
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
                        url: "/Tables/Intern/getjson/Orase"
                    }).done(function (response) {
                        data.resolve(response);
                    });
                    return data.promise();
                }
            },

            fields: [
                { name: "ID", type: "number", width: 70, validate: "required" },
                { name: "Nume", type: "text", width: 70, validate: "required" },
                { name: "NumeRomana", type: "text", width: 70, validate: "required" },
                { name: "NumeEngleza", type: "text", width: 70, validate: "required" }
            ]
        });

        break;
    case "Institutie":
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
                        url: "/Tables/Intern/getjson/Institutii"
                    }).done(function (response) {
                        data.resolve(response);
                    });
                    return data.promise();
                }
            },

            fields: [
            { name: "ID", type: "number",  validate: "required" },
            { name: "Nume", type: "text",  validate: "required" },
            { name: "NumeEngleza", type: "text",  validate: "required" },
            { name: "Acronim", type: "text",  validate: "required" },
            { name: "Adresapostala", type: "text",  validate: "required" },
            { name: "Adresaweb", type: "text", validate: "required" },
            { name: "CodErasmus", type: "text", validate: "required" },
            { name: "CodPIC", type: "text", validate: "required" },
            { name: "Descriere", type: "text", validate: "required" }
            ]
        });

        break;

    case "Institutii partenere":
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
            //data: clients,
            controller: {
                loadData: function (filter) {
                    var data = $.Deferred();
                    $.ajax({
                        type: "GET",
                        contentType: "application/json",
                        url: "/Tables/Intern/getjson/InstitutiiPart"
                    }).done(function (response) {
                        data.resolve(response);
                    });
                    return data.promise();
                }
            },
            fields: [
            { name: "ID", type: "number", validate: "required" },
            { name: "Nume", type: "text", validate: "required" },
            { name: "NumeRomana", type: "text", validate: "required" },
            { name: "NumeEngleza", type: "text", validate: "required" },
            { name: "Oras", type: "text", validate: "required" },
            { name: "Tippartener", type: "text", validate: "required" },
            { name: "Acronim", type: "text", validate: "required" },
            { name: "Adresapostala", type: "text", validate: "required" },
            { name: "Adresaweb", type: "text", validate: "required" },
            { name: "CodErasmus", type: "text", validate: "required" },
            { name: "CodPIC", type: "text", validate: "required" },
            { name: "CartaErasmus", type: "text", validate: "required" },
            { name: "AcordErasmus", type: "text", validate: "required" },
            { name: "Descriere", type: "text", validate: "required" }
            ]
        });

        break;
    case "Departamente":
        $("#jsGrids").jsGrid({
            width: "100%",
            height: "750px",

            autoload:true,
            filtering: true,
            inserting: true,
            selecting: true,
            editing: true,
            sorting: true,
            paging: true,
            pageSize: 15,


            deleteConfirm: "Do you really want to delete the client?",
            //data: clients,
            controller: {
                loadData: function (filter) {
                    var data = $.Deferred();
                    $.ajax({
                        type: "GET",
                        contentType: "application/json",
                        url: "/Tables/Intern/getjson/Departamente"
                    }).done(function (response) {
                        data.resolve(response);
                    });
                    return data.promise();
                }
            },
            fields: [
            { name: "ID", type: "number", validate: "required" },
            { name: "Nume", type: "text", validate: "required" },  
            { name: "NumeEngleza", type: "text", validate: "required" },
            { name: "Institutie", type: "text", validate: "required" },
            { name: "Acronim", type: "text", validate: "required" },
            { name: "Adresapostala", type: "text", validate: "required" },
            { name: "Adresaweb", type: "text", validate: "required" },
            { name: "Descriere", type: "text", validate: "required" }
            ]
        });

        break;
    case "Departamente partenere":
        $("#jsGrids").jsGrid({
            width: "100%",
            height: "750px",
            autoload:true,
            filtering: true,
            inserting: true,
            selecting: true,
            editing: true,
            sorting: true,
            paging: true,
            pageSize: 15,


            deleteConfirm: "Do you really want to delete the client?",
            //data: clients,
            controller: {
                loadData: function (filter) {
                    var data = $.Deferred();
                    $.ajax({
                        type: "GET",
                        contentType: "application/json",
                        url: "/Tables/Intern/getjson/DepartamentePart"
                    }).done(function (response) {
                        data.resolve(response);
                    });
                    return data.promise();
                }
            },
            fields: [
            { name: "ID", type: "number", validate: "required" },
            { name: "Nume", type: "text", validate: "required" },
            { name: "NumeRomana", type: "text", validate: "required" },
            { name: "NumeEngleza", type: "text", validate: "required" },
            { name: "Institutiepartenera", type: "text", validate: "required" },
            { name: "Acronim", type: "text", validate: "required" },
            { name: "Adresapostala", type: "text", validate: "required" },
            { name: "Adresaweb", type: "text", validate: "required" },
            { name: "Descriere", type: "text", validate: "required" }
            ]
        });

        break;
    case "Personal ATM":
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
            //data: clients,
            controller: {
                loadData: function (filter) {
                    var data = $.Deferred();
                    $.ajax({
                        type: "GET",
                        contentType: "application/json",
                        url: "/Tables/Intern/getjson/Personal"
                    }).done(function (response) {
                        data.resolve(response);
                    });
                    return data.promise();
                }
            },
            fields: [
                { name: "ID", type: "number", validate: "required" },
                { name: "Nume", type: "text", validate: "required" },
                { name: "Prenume", type: "text", validate: "required" },
                { name: "Datanasterii", type: "text", validate: "required" },
                { name: "Departament", type: "text", validate: "required" },
                { name: "SituatieActuala", type: "text", validate: "required" },
                { name: "SituatieErasmus", type: "text", validate: "required" },
                { name: "Functie", type: "text", validate: "required" },
                { name: "E-mail", type: "text", validate: "required" },
                { name: "Telefon", type: "text", validate: "required" },
                { name: "Descriere", type: "text", validate: "required" }
            ]
        });

        break;
    case "Participanti straini":
        $("#jsGrids").jsGrid({
            width: "100%",
            height: "750px",

            autoload:true,
            filtering: true,
            inserting: true,
            selecting: true,
            editing: true,
            sorting: true,
            paging: true,
            pageSize: 15,


            deleteConfirm: "Do you really want to delete the client?",
            //data: clients,
            controller: {
                loadData: function (filter) {
                    var data = $.Deferred();
                    $.ajax({
                        type: "GET",
                        contentType: "application/json",
                        url: "/Tables/Intern/getjson/Participanti"
                    }).done(function (response) {
                        data.resolve(response);
                    });
                    return data.promise();
                }
            },
            fields: [
            { name: "ID", type: "number", validate: "required" },
            { name: "Nume", type: "text", validate: "required" },
            { name: "Prenume", type: "text", validate: "required" },
            { name: "Departament", type: "text", validate: "required" },
            { name: "Situatieactuala", type: "text", validate: "required" },
            { name: "SituatieErasmus", type: "text", validate: "required" },
            { name: "Functie", type: "text", validate: "required" },
            { name: "E-mail", type: "text", validate: "required" },
            { name: "Telefon", type: "text", validate: "required" },
            { name: "Descriere", type: "text", validate: "required" }
            ]
        });
        break;
    case "Detalii mobilitati":
        $("#jsGrids").jsGrid({
            width: "100%",
            height: "750px",

            autoload:true,
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
                        url: "/Tables/Intern/getjson/Mobilitati"
                    }).done(function (response) {
                        data.resolve(response);
                    });
                    return data.promise();
                }
            },

            fields: [
                { name: "ID", type: "number", width: 70, validate: "required" },
                { name: "An", type: "number", width: 70, validate: "required" },
                { name: "Tipmobilitate", type: "select", items: tip, valueField: "Id", textField: "Name" },
                { name: "Nivel", type: "select", items: nivel, valueField: "Id", textField: "Name" },
                { name: "Numesiprenume", type: "text", width: 150, validate: "required" },
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

        break;

    case "Participanti la mobilitati":
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
            //data: clients,
            controller: {
                loadData: function (filter) {
                    var data = $.Deferred();
                    $.ajax({
                        type: "GET",
                        contentType: "application/json",
                        url: "/Person/Intern/getJson"
                    }).done(function (response) {
                        data.resolve(response);
                    });
                    return data.promise();
                }
            },
            fields: [
                { name: "ID", type: "number", validate: "required" },
                { name: "Nume", type: "text", validate: "required" },
                { name: "Prenume", type: "text", validate: "required" },
                { name: "Departament", type: "text", validate: "required" },
                { name: "Situatieactuala", type: "text", validate: "required" },
                { name: "SituatieErasmus", type: "text", validate: "required" },
                { name: "Functie", type: "text", validate: "required" },
                { name: "E-mail", type: "text", validate: "required" },
                { name: "Telefon", type: "text", validate: "required" },
                { name: "Descriere", type: "text", validate: "required" }
            ]
        });
        break;

default: break;
}
