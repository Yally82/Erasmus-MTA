
$(document).ready(function () {
    var m_o_part = getRemote("/Tables/getMedia/PersonalATM");

    function getRemote(remote_url) {
        return $.ajax({
            type: "GET",
            url: remote_url,
            async: false
        });
    }

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

                reloadAfterSubmit: true,

                controller: {
                    loadData: function (filter) {
                        return $.ajax({
                            type: "GET",
                            url: "/Tables/getMedia/Tara",
                            data: filter
                        });
                    },
                    insertItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/insertTara",
                            data: item,
                            dataType: "json"
                        });
                    },
                    updateItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/updateTara/" + item.ID,
                            data: item,
                            dataType: "json"
                        });
                    },
                    deleteItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/deleteMedia/Tara/" + item.ID
                        });
                    }
                },

                fields: [
                    { name: "ID", type: "number", width: 70, validate: "required", align: "center" },
                    { name: "Nume", type: "text", width: 70, validate: "required" },
                    { name: "NumeRomana", type: "text", width: 70, validate: "required" },
                    { name: "NumeEngleza", type: "text", width: 70, validate: "required" },
                    {
                        type: "control", width: 50,
                        itemTemplate: function (value, item) {
                            var $result = jsGrid.fields.control.prototype.itemTemplate.apply(this, arguments);
                            return $result;
                        }
                    }
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
                        return $.ajax({
                            type: "GET",
                            url: "/Tables/getMedia/Oras",
                            data: filter
                        });
                    },
                    insertItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/insertOras",
                            data: item,
                            dataType: "json"
                        });
                    },
                    updateItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/updateOras/" + item.ID,
                            data: item,
                            dataType: "json"
                        });
                    },
                    deleteItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/deleteMedia/Oras/" + item.ID
                        });
                    }
                },

                fields: [
                    { name: "ID", type: "number",width: 70, validate: "required", align: "center" },
                    { name: "Nume", type: "text", width: 70, validate: "required" },
                    { name: "NumeRomana", type: "text", width: 70, validate: "required" },
                    { name: "NumeEngleza", type: "text", width: 70, validate: "required" },
                    {
                        type: "control", width: 50,
                        itemTemplate: function (value, item) {
                            var $result = jsGrid.fields.control.prototype.itemTemplate.apply(this, arguments);
                            return $result;
                        }
                    }
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
                        return $.ajax({
                            type: "GET",
                            url: "/Tables/getMedia/Institutie",
                            data: filter
                        });
                    },
                    insertItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/insertInstitutie",
                            data: item,
                            dataType: "json"
                        });
                    },
                    updateItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/updateInstitutie/" + item.ID,
                            data: item,
                            dataType: "json"
                        });
                    },
                    deleteItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/deleteMedia/Institutie/" + item.ID
                        });
                    }
                },

                fields: [
                    { name: "ID", type: "number", validate: "required", align: "center" },
                    { name: "Nume", type: "text", validate: "required" },
                    { name: "NumeEngleza", type: "text", validate: "required" },
                    { name: "Acronim", type: "text", validate: "required" },
                    { name: "AdresaPostala", type: "text", validate: "required" },
                    { name: "AdresaWeb", type: "text", validate: "required" },
                    { name: "CodErasmus", type: "text", validate: "required" },
                    { name: "CodPIC", type: "text", validate: "required" },
                    { name: "Descriere", type: "text", validate: "required" },
                    {
                        type: "control", width: 50,
                        itemTemplate: function (value, item) {
                            var $result = jsGrid.fields.control.prototype.itemTemplate.apply(this, arguments);
                            return $result;
                        }
                    }
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
                        return $.ajax({
                            type: "GET",
                            url: "/Tables/getMedia/InstitutiiPartenere",
                            data: filter
                        });
                    },
                    insertItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/insertInstitutiiPartenere",
                            data: item,
                            dataType: "json"
                        });
                    },
                    updateItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/updateInstitutiiPartenere/" + item.ID,
                            data: item,
                            dataType: "json"
                        });
                    },
                    deleteItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/deleteMedia/InstitutiiPartenere/" + item.ID
                        });
                    }
                },
                fields: [
                    { name: "ID", type: "number", validate: "required", align: "center" },
                    { name: "Nume", type: "text", validate: "required" },
                    { name: "NumeRomana", type: "text", validate: "required" },
                    { name: "NumeEngleza", type: "text", validate: "required" },
                    { name: "Oras", type: "text", validate: "required" },
                    { name: "TipPartener", type: "text", validate: "required" },
                    { name: "Acronim", type: "text", validate: "required" },
                    { name: "AdresaPostala", type: "text", validate: "required" },
                    { name: "AdresaWeb", type: "text", validate: "required" },
                    { name: "CodErasmus", type: "text", validate: "required" },
                    { name: "CodPIC", type: "text", validate: "required" },
                    { name: "CartaErasmus", type: "text", validate: "required" },
                    { name: "AcordErasmus", type: "text", validate: "required" },
                    { name: "Descriere", type: "text", validate: "required" },
                    {
                        type: "control", width: 50,
                        itemTemplate: function (value, item) {
                            var $result = jsGrid.fields.control.prototype.itemTemplate.apply(this, arguments);
                            return $result;
                        }
                    }
                ]
            });

            break;
        case "Departamente":
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
                        return $.ajax({
                            type: "GET",
                            url: "/Tables/getMedia/DepartamenteATM",
                            data: filter
                        });
                    },
                    insertItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/insertDepartamenteATM",
                            data: item,
                            dataType: "json"
                        });
                    },
                    updateItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/updateDepartamenteATM/" + item.ID,
                            data: item,
                            dataType: "json"
                        });
                    },
                    deleteItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/deleteMedia/DepartamenteATM/" + item.ID
                        });
                    }
                },
                fields: [
                    { name: "ID", type: "number", validate: "required", align: "center" },
                    { name: "Nume", type: "text", validate: "required" },
                    { name: "NumeEngleza", type: "text", validate: "required" },
                    { name: "Institutie", type: "text", validate: "required" },
                    { name: "Acronim", type: "text", validate: "required" },
                    { name: "AdresaPostala", type: "text", validate: "required" },
                    { name: "AdresaWeb", type: "text", validate: "required" },
                    { name: "Descriere", type: "text", validate: "required" },
                    {
                        type: "control", width: 50,
                        itemTemplate: function (value, item) {
                            var $result = jsGrid.fields.control.prototype.itemTemplate.apply(this, arguments);
                            return $result;
                        }
                    }
                ]
            });

            break;
        case "Departamente partenere":
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
                        return $.ajax({
                            type: "GET",
                            url: "/Tables/getMedia/DepartamentePartenere",
                            data: filter
                        });
                    },
                    insertItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/insertDepartamentePartenere",
                            data: item,
                            dataType: "json"
                        });
                    },
                    updateItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/updateDepartamentePartenere/" + item.ID,
                            data: item,
                            dataType: "json"
                        });
                    },
                    deleteItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/deleteMedia/DepartamentePartenere/" + item.ID
                        });
                    }
                },
                fields: [
                    { name: "ID", type: "number", validate: "required", align: "center" },
                    { name: "Nume", type: "text", validate: "required" },
                    { name: "NumeRomana", type: "text", validate: "required" },
                    { name: "NumeEngleza", type: "text", validate: "required" },
                    { name: "InstitutiePartenera", type: "text", validate: "required" },
                    { name: "Acronim", type: "text", validate: "required" },
                    { name: "AdresaPostala", type: "text", validate: "required" },
                    { name: "AdresaWeb", type: "text", validate: "required" },
                    { name: "Descriere", type: "text", validate: "required" },
                    {
                        type: "control", width: 50,
                        itemTemplate: function (value, item) {
                            var $result = jsGrid.fields.control.prototype.itemTemplate.apply(this, arguments);
                            return $result;
                        }
                    }
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
                        return $.ajax({
                            type: "GET",
                            url: "/Tables/getMedia/PersonalATM",
                            data: filter
                        });
                    },
                    insertItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/insertPersonalATM",
                            data: item,
                            dataType: "json"
                        });
                    },
                    updateItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/updatePersonalATM/" + item.ID,
                            data: item,
                            dataType: "json"
                        });
                    },
                    deleteItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/deleteMedia/PersonalATM/" + item.ID
                        });
                    }
                },
                fields: [
                    { name: "ID", type: "number", validate: "required", align: "center" },
                    { name: "Nume", type: "text", validate: "required" },
                    { name: "Prenume", type: "text", validate: "required" },
                    { name: "DataNasterii", type: "text", validate: "required" },
                    { name: "Departament", type: "text", validate: "required" },
                    { name: "SituatieActuala", type: "text", validate: "required" },
                    { name: "SituatieErasmus", type: "text", validate: "required" },
                    { name: "Functie", type: "text", validate: "required" },
                    { name: "Email", type: "text", validate: "required", width: 150 },
                    { name: "Telefon", type: "text", validate: "required" },
                    { name: "Descriere", type: "text", validate: "required" },
                    {
                        type: "control", width: 50,
                        itemTemplate: function (value, item) {
                            var $result = jsGrid.fields.control.prototype.itemTemplate.apply(this, arguments);
                            return $result;
                        }
                    }
                ]
            });

            break;
        case "Participanti straini":
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
                        return $.ajax({
                            type: "GET",
                            url: "/Tables/getMedia/ParticipantiStraini",
                            data: filter
                        });
                    },
                    insertItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/insertParticipantiStraini",
                            data: item,
                            dataType: "json"
                        });
                    },
                    updateItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/updateParticipantiStraini/" + item.ID,
                            data: item,
                            dataType: "json"
                        });
                    },
                    deleteItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/deleteMedia/ParticipantiStraini/" + item.ID
                        });
                    }
                },
                fields: [
                    { name: "ID", type: "number", validate: "required", width: 50, align: "center" },
                    { name: "Nume", type: "text", validate: "required" },
                    { name: "Prenume", type: "text", validate: "required" },
                    { name: "Departament", type: "text", validate: "required" },
                    { name: "SituatieActuala", type: "text", validate: "required" },
                    { name: "SituatieErasmus", type: "text", validate: "required" },
                    { name: "Functie", type: "text", validate: "required" },
                    { name: "Email", type: "text", validate: "required", width: 150 },
                    { name: "Telefon", type: "text", validate: "required" },
                    { name: "Descriere", type: "text", validate: "required" },
                    {
                        type: "control", width: 50,
                        itemTemplate: function (value, item) {
                            var $result = jsGrid.fields.control.prototype.itemTemplate.apply(this, arguments);
                            return $result;
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
                    { name: "ID", type: "number", validate: "required", align: "center" },
                    { name: "Nume", type: "text", validate: "required" },
                    { name: "Prenume", type: "text", validate: "required" },
                    { name: "Departament", type: "text", validate: "required" },
                    { name: "SituatieActuala", type: "text", validate: "required" },
                    { name: "SituatieErasmus", type: "text", validate: "required" },
                    { name: "Functie", type: "text", validate: "required" },
                    { name: "Email", type: "text", validate: "required", width: 150 },
                    { name: "Telefon", type: "text", validate: "required" },
                    { name: "Descriere", type: "text", validate: "required" },
                    {
                        type: "control", width: 50,
                        itemTemplate: function (value, item) {
                            var $result = jsGrid.fields.control.prototype.itemTemplate.apply(this, arguments);
                            return $result;
                        }
                    }
                ]
            });
            break;
        case "Mobilitati Outgoing":
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
                        return $.ajax({
                            type: "GET",
                            url: "/Tables/getMedia/MobilitateOutgoing",
                            data: filter
                        });
                    },
                    insertItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/insertOutgoingMobility",
                            data: item,
                            dataType: "json"
                        });
                    },
                    deleteItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/deleteMedia/MobilitateOutgoing/" + item.ID
                        });
                    }
                },

                fields: [
                    { name: "ID", type: "number", width: 70, validate: "required", align: "center" },
                    {
                        name: "ParticipantATM", type: "select", items: getRemote("/Tables/getMedia/PersonalATM"), valueField: "ID", textField: "Nume",
                        filterTemplate: function () {
                            var statesField = this._grid.fields[2];
                            var $filterControl = jsGrid.fields.select.prototype.filterTemplate.call(this);

                            $filterControl.on("change", function () {
                                var selectedCountry = parseInt($(this).val(), 10);
                                var countryStates = $.grep(getRemote("/Tables/getMedia/PersonalATM"), function (country) {
                                    return country.ID === selectedCountry;
                                })[0].States;

                               
                            });

                            return $filterControl;
                        }
                    }
                ]
            });

            break;
        case "Mobilitati Incoming":
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
                        return $.ajax({
                            type: "GET",
                            url: "/Tables/getMedia/MobilitateIncoming",
                            data: filter
                        });
                    },
                    insertItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/insertIncomingMobility",
                            data: item,
                            dataType: "json"
                        });
                    },
                    deleteItem: function (item) {
                        return $.ajax({
                            type: "POST",
                            url: "/Tables/deleteMedia/MobilitateIncoming/" + item.ID
                        });
                    }
                },

                fields: [
                    { name: "ID", type: "number", width: 70, validate: "required", align: "center" },
                    { name: "An", type: "number", width: 70, validate: "required" }
                ]
            });

            break;


        default: break;
    }

});