﻿
jQuery(document).ready(function () {

    //Ocultamos imágen del fantasma
    jQuery("#ghost").toggle();
    jQuery("#dialog-modal").toggle();




    //Definimos Modelo (Por ahora no hace nada)

    var mapa = Backbone.Model.extend({

        mapa: "",
        latlng: "",
        url: "traerArreglo",
        myOptions: "",
        historiasgeneral: "",
        initialize: function () {

            /* this.bind("change:historiasgeneral", function () {
            alert("Triggered ");
            });*/

        },
        quitardelmapa: function () {
            jQuery.each(this.get("historiasgeneral"), function (index, value) {

                value.setMap(null);

            });

        },

        reponerdelmapa: function () {
            jQuery.each(this.get("historiasgeneral"), function (index, value) {
               
                value.setMap(instModelo.get("mapa"));

            });


        }

    });

    //Definimos Vista

    var vistaPrincipal = Backbone.View.extend({
        model: mapa,
        el: "div",
        id: "Principal",

        events: {

    },

    initialize: function () {

        //Seteamos latitud y longitud por defecto

        this.model.set({ latlng: new google.maps.LatLng(-32.325659, -58.083993) });

        // Seteamos arreglo de opciones para el mapa

        this.model.set({ myOptions: {
            zoom: 17,
            center: this.model.get('latlng'),
            disableDefaultUI: true,
            mapTypeId: google.maps.MapTypeId.SATELLITE
        }
        });


        //Asignamos mapa a un elemento de la vista para presentación

        this.model.set({ mapa: new google.maps.Map(document.getElementById("mapa_canvas"), this.model.get('myOptions')) });

        this.model.set({ historiasgeneral: new Array() });

        var map = this.model.get("mapa");

        google.maps.event.addListener(map, 'zoom_changed', function () {
            var zoom = map.getZoom()
            
            if (zoom < 17) {
                instModelo.quitardelmapa();
            } else {
                instModelo.reponerdelmapa();
            }
        });


        Backbone.sync("UPDATE", this.model, { success:

        function (data) {

            var arreglogeneral = new Array();

            arreglogeneral = instModelo.get('historiasgeneral');

            var contador = 0;

            while (contador < data.length) {
                var latlng = new google.maps.LatLng(data[contador].geolat, data[contador].geolon);

                //Creamos marcador


                var marker = new google.maps.Marker({
                    position: latlng,
                    icon: "../../Content/images/casaembrujada.gif",
                    map: instModelo.get('mapa'),
                    title: data[contador].titulo
                });

                arreglogeneral.push(marker);

                google.maps.event.addListener(marker, 'click', function () {
                    //            jQuery("#vistaHistoria").toggle();


                    jQuery("#dialog-modal").load('../Principal/Historia #historia');

                    jQuery("#dialog-modal").dialog({
                        modal: true
                    });
                });

                contador++;
            }

        }
        }

        );


    }

});


var instModelo = new mapa();

var instVista = new vistaPrincipal({ model: instModelo });




//Funcion de animación, ¡little ghostly!

setTimeout(function () {


    jQuery("#ghost").toggle();

    //EJEMPLO CON JSANIM

    var manager = new jsAnimManager(40);

    var anim = manager.createAnimObject(jQuery("#ghost").attr("id"));


    manager.registerPosition("ghost", false);

    var el = document.getElementById("ghost");

    el.setPosition(0, 0);


    anim.add({
        property: Prop.width,
        from: 50,
        to: 500,
        duration: 2000,
        ease: jsAnimEase.standard,
        //loop: 2,
        onLoop: function () {



        },
        onComplete: function () {

            anim.add({
                property: Prop.positionSemicircle(false),
                to: new Pos(250, 25),
                loop: 2,
                duration: 2000,
                onComplete: function () {

                    jQuery("#ghost").toggle();

                }
            });

        }
    });

}, 30000);




});