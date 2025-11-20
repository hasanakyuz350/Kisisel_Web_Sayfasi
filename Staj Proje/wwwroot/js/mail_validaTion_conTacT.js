document.addEventListener("DOMContentLoaded", function () {
    var form = document.querySelector("form");
    form.addEventListener("submit", function (e) {
        var email = form.querySelector("input[name='email']").value;
        var emailneed = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

        if (!emailneed.test(email)) {
            alert("Eksik ya da doğru olmayan bir mail adresi girdiniz!");
            e.preventDefault();
        }
    });
});