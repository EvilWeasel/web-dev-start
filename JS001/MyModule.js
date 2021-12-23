
var MyModule = (function () {
    function writevar(a) {
        console.log("a:" + a + ", " + typeof (a))
    }
    function _help01() {

    }
    return {
        "consolelog": writevar,
        "winfried": { "Name": "Winfried", "Farbe": "Grün" },
        "minischderpraesidend": {string : writevar(0)}
    }
})()
