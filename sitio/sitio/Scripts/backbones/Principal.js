
jQuery(document).ready(function () {

    //Ocultamos imágen del fantasma
    jQuery("#ghost").toggle();
    jQuery("#vistaHistoria").toggle();
   



    //Definimos Modelo (Por ahora no hace nada)

    var mapa = Backbone.Model.extend({

        mapa: "",
        latlng: "",
        myOptions: "",
        historiasgeneral: "",
        initialize: function () {

            /* this.bind("change:historiasgeneral", function () {
            alert("Triggered ");
            });*/

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
            zoom: 15,
            center: this.model.get('latlng'),
            disableDefaultUI: true,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        }
        });


        //Asignamos mapa a un elemento de la vista para presentación

        this.model.set({ mapa: new google.maps.Map(document.getElementById("mapa_canvas"), this.model.get('myOptions')) });

        this.model.set({ historiasgeneral: new Array() });


        // **************PRUEBA
        //Creamos marcador de prueba

        var latlng = new google.maps.LatLng(-32.325659, -58.083993);

        var marker = new google.maps.Marker({
            position: latlng,
            map: this.model.get('mapa'),
            title: "Hello World!"
        });


        //Probamos operaciones con los arreglos        
        var arreglogeneral = new Array();
        arreglogeneral = this.model.get('historiasgeneral');
        arreglogeneral.push(marker);

        //Cambiamos el titulo, a través de la variable de función
        arreglogeneral[0].setTitle("El mostro de la noche");



        //****************


        google.maps.event.addListener(marker, 'click', function () {
            //            jQuery("#vistaHistoria").toggle();


            jQuery("#vistaHistoria").load('../Principal/Historia #historia');

            jQuery("#vistaHistoria").dialog({
                height: 140,
                modal: true
            });
        });



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