// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

document.addEventListener("DOMContentLoaded", function () {
    const eventList = document.querySelector(".event-list");
    const scrollButtonLeft = document.querySelector(".scroll-button-left");
    const scrollButtonRight = document.querySelector(".scroll-button-right");

    let scrollPosition = 0;

    scrollButtonLeft.addEventListener("click", function () {
        scrollPosition -= 350; // Ajusta la cantidad de desplazamiento según tus necesidades
        eventList.style.transform = `translateX(${scrollPosition}px)`;
    });

    scrollButtonRight.addEventListener("click", function () {
        scrollPosition += 350; // Ajusta la cantidad de desplazamiento según tus necesidades
        eventList.style.transform = `translateX(${scrollPosition}px)`;
    });
});

// Obtener el elemento del popup y el botón de cierre
const eventPopup = document.getElementById("eventPopup");
const closePopup = document.getElementById("closePopup");

// Función para mostrar el popup con los datos del evento seleccionado
function showPopup(eventID) {
    const eventPopup = document.querySelector(".popup");
    eventPopup.style.display = "block";
    eventPopup.style.top = "50%";
    eventPopup.style.left = "50%";
    eventPopup.style.transform = "translate(-50%, -50%)";
}

// Llama a la función showPopup con los datos del evento seleccionado
showPopup(eventID);


// Función para ocultar el popup
function hidePopup() {
    eventPopup.style.display = "none";
}

// Agregar un evento de clic a cada evento para mostrar el popup
const events = document.querySelectorAll(".event");
events.forEach((event) => {
    event.addEventListener("click", showPopup);
});

// Agregar un evento de clic al botón de cierre para ocultar el popup
closePopup.addEventListener("click", hidePopup);
