let map;

function initAdd() {
    const myLatlng = { lat: 18.735693, lng: -70.162651 };
    map = new google.maps.Map(document.getElementById("map"), {
        center: myLatlng,
        zoom: 8,
    });

    let infoWindow = new google.maps.InfoWindow({
        content: "Click al mapa para obtener latitud y longitud",
        position: myLatlng,
    });
    infoWindow.open(map);
    // Configure the click listener.
    map.addListener("click", (mapsMouseEvent) => {
        // Close the current InfoWindow.
        infoWindow.close();
        // Create a new InfoWindow.
        infoWindow = new google.maps.InfoWindow({
            position: mapsMouseEvent.latLng,
        });
        infoWindow.setContent(
            JSON.stringify(mapsMouseEvent.latLng.toJSON(), null, 2)
        );
        infoWindow.open(map);
    });

}