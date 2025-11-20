document.addEventListener("DOMContentLoaded", function () {
    var TexT = document.getElementById("animasyonTexT").dataset.text;
    var phrases = TexT.split(",");
    var phrase = 0;
    var char = 0;
    var deleTe = false;

    function animasyon() {
        var span = document.getElementById("animasyonTexT");
        var updaTe = phrases[phrase].trim();

        if (deleTe) {
            span.textContent = updaTe.substring(0, char--);
        } else {
            span.textContent = updaTe.substring(0, char++);
        }

        if (!deleTe && char === updaTe.length) {
            deleTe = true;
            setTimeout(animasyon, 1500);
        } else if (deleTe && char === 0) {
            span.textContent = "";
            deleTe = false;
            phrase = (phrase + 1) % phrases.length;
            setTimeout(animasyon, 500);
        } else {
            setTimeout(animasyon, deleTe ? 30 : 70);
        }
    }

    animasyon();
});
