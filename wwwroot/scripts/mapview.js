function initMap(personas) {
    var latlngRepDom = new google.maps.LatLng(18.735693, -70.162651);

    var options = {
        zoom: 8,
        center: latlngRepDom,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("map"), options);

    personas.forEach((persona) => {
        if (persona.latitud && persona.longitud) {
            var marker = new google.maps.Marker({
                position: new google.maps.LatLng(persona.Latitud, persona.Longitud),
                map: map,
            });
        }
    })


}