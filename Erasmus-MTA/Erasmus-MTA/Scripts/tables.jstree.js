
switch ($("#tipTabel").text()) {
    case "Tari":
        $("#jsGrid").jsGrid({
            width: "100%",
            height: "750px",

            filtering: true,
            inserting: true,
            selecting: true,
            editing: true,
            sorting: true,
            paging: true,
            pageSize: 15,
            autoload: true,

            deleteConfirm: "Do you really want to delete the client?",

            controller: {
                loadData: function () {
                    var d = $.Deferred();

                    $.ajax({
                        type: "GET",
                        url: "Tables/Intern/getjson/Tara",
                        dataType: "json"
                    }).done(function (response) {
                        d.resolve(response.value);
                    });

                    return d.promise();
                }
            },

            fields: [
                { name: "ID", type: "number", width: 70, validate: "required" },
                { name: "Nume", type: "text", width: 70, validate: "required" },
                { name: "Nume romana", type: "text", width: 70, validate: "required" },
                { name: "Nume Engleza", type: "text", width: 70, validate: "required" }
            ]
        });

    break;

    case "Institutii":
        $("#jsGrids").jsGrid({
            width: "100%",
            height: "750px",
            filtering: true,
            inserting: true,
            selecting: true,
            editing: true,
            sorting: true,
            paging: true,
            pageSize: 15,


            deleteConfirm: "Do you really want to delete the client?",
            //data: clients,

            fields: [
            { name: "ID", type: "number",  validate: "required" },
            { name: "Nume", type: "text",  validate: "required" },
            { name: "Nume Engleza", type: "text",  validate: "required" },
            { name: "Acronim", type: "text",  validate: "required" },
            { name: "Adresa postala", type: "text",  validate: "required" },
            { name: "Adresa web", type: "text", validate: "required" },
            { name: "Cod Erasmus", type: "text", validate: "required" },
            { name: "Cod PIC", type: "text", validate: "required" },
            { name: "Descriere", type: "text", validate: "required" }
            ]
        });

        break;
    case "Institutii partenere":
        $("#jsGrids").jsGrid({
            width: "100%",
            height: "750px",
            filtering: true,
            inserting: true,
            selecting: true,
            editing: true,
            sorting: true,
            paging: true,
            pageSize: 15,


            deleteConfirm: "Do you really want to delete the client?",
            //data: clients,

            fields: [
            { name: "ID", type: "number", validate: "required" },
            { name: "Nume", type: "text", validate: "required" },
            { name: "Nume Romana", type: "text", validate: "required" },
            { name: "Nume Engleza", type: "text", validate: "required" },
            { name: "Oras", type: "text", validate: "required" },
            { name: "Tip partener", type: "text", validate: "required" },
            { name: "Acronim", type: "text", validate: "required" },
            { name: "Adresa postala", type: "text", validate: "required" },
            { name: "Adresa web", type: "text", validate: "required" },
            { name: "Cod Erasmus", type: "text", validate: "required" },
            { name: "Cod PIC", type: "text", validate: "required" },
            { name: "Carta Erasmus", type: "text", validate: "required" },
            { name: "Acord Erasmus", type: "text", validate: "required" },
            { name: "Descriere", type: "text", validate: "required" }
            ]
        });

        break;
    case "Departamente":
        $("#jsGrids").jsGrid({
            width: "100%",
            height: "750px",
            filtering: true,
            inserting: true,
            selecting: true,
            editing: true,
            sorting: true,
            paging: true,
            pageSize: 15,


            deleteConfirm: "Do you really want to delete the client?",
            //data: clients,

            fields: [
            { name: "ID", type: "number", validate: "required" },
            { name: "Nume", type: "text", validate: "required" },  
            { name: "Nume Engleza", type: "text", validate: "required" },
            { name: "Institutie", type: "text", validate: "required" },
            { name: "Acronim", type: "text", validate: "required" },
            { name: "Adresa postala", type: "text", validate: "required" },
            { name: "Adresa web", type: "text", validate: "required" },
            { name: "Descriere", type: "text", validate: "required" }
            ]
        });

        break;
    case "Departamente partenere":
        $("#jsGrids").jsGrid({
            width: "100%",
            height: "750px",
            filtering: true,
            inserting: true,
            selecting: true,
            editing: true,
            sorting: true,
            paging: true,
            pageSize: 15,


            deleteConfirm: "Do you really want to delete the client?",
            //data: clients,

            fields: [
            { name: "ID", type: "number", validate: "required" },
            { name: "Nume", type: "text", validate: "required" },
            { name: "Nume Romana", type: "text", validate: "required" },
            { name: "Nume Engleza", type: "text", validate: "required" },
            { name: "Institutie partenera", type: "text", validate: "required" },
            { name: "Acronim", type: "text", validate: "required" },
            { name: "Adresa postala", type: "text", validate: "required" },
            { name: "Adresa web", type: "text", validate: "required" },
            { name: "Descriere", type: "text", validate: "required" }
            ]
        });

        break;
    case "Personal ATM":
        $("#jsGrids").jsGrid({
            width: "100%",
            height: "750px",
            filtering: true,
            inserting: true,
            selecting: true,
            editing: true,
            sorting: true,
            paging: true,
            pageSize: 15,


            deleteConfirm: "Do you really want to delete the client?",
            //data: clients,

            fields: [
            { name: "ID", type: "number", validate: "required" },
            { name: "Nume", type: "text", validate: "required" },
            { name: "Prenume", type: "text", validate: "required" },
            { name: "Data nasterii", type: "text", validate: "required" },
            { name: "Departament", type: "text", validate: "required" },
            { name: "Situatie actuala", type: "text", validate: "required" },
            { name: "Situatie Erasmus", type: "text", validate: "required" },
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
            filtering: true,
            inserting: true,
            selecting: true,
            editing: true,
            sorting: true,
            paging: true,
            pageSize: 15,


            deleteConfirm: "Do you really want to delete the client?",
            //data: clients,

            fields: [
            { name: "ID", type: "number", validate: "required" },
            { name: "Nume", type: "text", validate: "required" },
            { name: "Prenume", type: "text", validate: "required" },
            { name: "Data nasterii", type: "text", validate: "required" },
            { name: "Departament", type: "text", validate: "required" },
            { name: "Situatie actuala", type: "text", validate: "required" },
            { name: "Situatie Erasmus", type: "text", validate: "required" },
            { name: "Functie", type: "text", validate: "required" },
            { name: "E-mail", type: "text", validate: "required" },
            { name: "Telefon", type: "text", validate: "required" },
            { name: "Descriere", type: "text", validate: "required" }
            ]
        });
        break;
    case "Detalii mobilitati":
        var clients = [
          { "ID": 0, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
          { "ID": 1, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
          { "ID": 2, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
          { "ID": 3, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
          { "ID": 4, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
          { "ID": 5, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
          { "ID": 6, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
          { "ID": 7, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
          { "ID": 8, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
          { "ID": 9, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
          { "ID": 10, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
          { "ID": 11, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
          { "ID": 12, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
          { "ID": 13, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
          { "ID": 14, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
          { "ID": 15, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
        ];
        var mobilitati = [
          { "ID": 0, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Institutia gazda": "Univ Bilbao" },
          { "ID": 1, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Institutia gazda": "Univ Bilbao" },
          { "ID": 2, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Institutia gazda": "Univ Bilbao" },
          { "ID": 3, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Institutia gazda": "Univ Bilbao" },
          { "ID": 4, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Institutia gazda": "Univ Bilbao" },
          { "ID": 5, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Institutia gazda": "Univ Bilbao" },
          { "ID": 6, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Institutia gazda": "Univ Bilbao" },
          { "ID": 7, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Institutia gazda": "Univ Bilbao" },

        ];
        var tip = {
            name: "Tip mobilitate",
            type: "select",
            items: [
              { Name: "", Id: 0 },
              { Name: "SMS", Id: 1 },
              { Name: "SMP", Id: 2 },
              { Name: "SM", Id: 3 },
            ],
            valueField: "Id",
            textField: "Name"
        }
        var nivel = {
            name: "Nivel",
            type: "select",
            items: [
              { Name: "", Id: 0 },
              { Name: "L", Id: 1 },
              { Name: "M", Id: 2 },
              { Name: "P", Id: 3 },
            ],
            valueField: "Id",
            textField: "Name"
        }

        $("#jsGrids").jsGrid({
            width: "100%",
            height: "750px",

            filtering: true,
            inserting: true,
            selecting: true,
            editing: true,
            sorting: true,
            paging: true,
            pageSize: 15,


            deleteConfirm: "Do you really want to delete the client?",
            data: clients,

            fields: [
                { name: "ID", type: "number", width: 70, validate: "required" },
                { name: "An", type: "number", width: 70, validate: "required" },
                { name: "Tip mobilitate", type: "select", items: tip, valueField: "Id", textField: "Name" },
                { name: "Nivel", type: "select", items: nivel, valueField: "Id", textField: "Name" },
                { name: "Nume si prenume", type: "text", width: 150, validate: "required" },
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


default: break;
}
