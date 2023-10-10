// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
document.addEventListener("DOMContentLoaded", function () {
    // Inicializar el Carousel
    const eventCarousel = new bootstrap.Carousel(document.getElementById("eventCarousel"));

    // Obtener el elemento del modal
    const eventModal = new bootstrap.Modal(document.getElementById("eventModal"));

    // Función para mostrar el modal con los datos del evento seleccionado
    function showPopup(eventID) {
        // Configura los datos del evento en el modal (reemplaza esto con tus datos reales)
        const eventTitle = "Título del Evento";
        const eventDescription = "Descripción del evento";
        const eventTime = "Hora del evento";

        const modalTitle = document.getElementById("eventModalLabel");
        const modalBody = document.querySelector(".modal-body");

        modalTitle.textContent = eventTitle;
        modalBody.innerHTML = `<p><strong>Título:</strong> ${eventDescription}</p><p><strong>Hora:</strong> ${eventTime}</p>`;

        // Muestra el modal
        eventModal.show();
    }

    // Agregar un evento de clic a cada evento para mostrar el modal
    const events = document.querySelectorAll(".event");
    events.forEach((event) => {
        event.addEventListener("click", function () {
            const eventID = event.dataset.eventId; // Obtén el ID del evento (ajusta según tu estructura)
            showPopup(eventID);
        });
    });
});

