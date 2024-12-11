// People
//======================================================================================================

// Create tabs
$(function () {
    $("#tabs").tabs();
});

// Open Modal for people
function handleOpenPersonModal(element) {
    var person = JSON.parse(element.getAttribute('data-faculty'));

    var modalContent = `
        <div class="text-center">
            <img src="${person.imagePath}" alt="${person.name}'s photo" width="100" height="100" style="border-radius: 50%;" />
        </div>
        <h5 class="text-center">${person.name}</h5>
        <h6 class="text-center text-muted">${person.title}</h6>
        <h6 class="text-center text-muted">${person.tagline}</h6>
    `;

    // Append other details
    if (person.office) modalContent += `<p><strong>Office:</strong> ${person.office}</p>`;
    if (person.website) modalContent += `<p><strong>Website:</strong> <a href="${person.website}" target="_blank">${person.website}</a></p>`;
    if (person.interestArea) modalContent += `<p><strong>Interest Areas:</strong> ${person.interestArea.toUpperCase() }</p>`;
    if (person.phone) modalContent += `<p><strong>Phone:</strong> ${person.phone}</p>`;
    if (person.email) modalContent += `<p><strong>Email:</strong> <a href="mailto:${person.email}">${person.email}</a></p>`;
    if (person.twitter) modalContent += `<p><strong>Twitter:</strong> <a href="https://twitter.com/${person.twitter}" target="_blank">${person.twitter}</a></p>`;
    if (person.facebook) modalContent += `<p><strong>Facebook:</strong> <a href="https://facebook.com/${person.facebook}" target="_blank">${person.facebook}</a></p>`;

    // Update the modal content with the generated HTML
    $('#modalBodyContent').empty().append(modalContent);

    // Show the modal using Bootstrap's modal method
    var myModal = new bootstrap.Modal($('#personModal'));
    myModal.show();
}



// Minors 
//======================================================================================================

// Add click event to all course links
$(document).ready(function () {
    $(".course-link").on("click", function () {
        const courseId = $(this).data("course-id"); // Get course ID from data attribute

        // Use fetch API to retrieve course details
        fetch(`/Home/GetCourseDetails?courseId=${courseId}`) // Endpoint to fetch course details
            .then(response => {
                if (!response.ok) {
                    throw new Error("Failed to fetch course details");
                }
                return response.json();
            })
            .then(data => {
                // Populate modal with retrieved data
                $("#courseModalTitle").text(data.title || "No Title Available");
                $("#courseModalLabel").text(courseId || "No ID Available");
                $("#courseModalDescription").text(data.description || "No Description Available");

                // Show the modal using jQuery
                $("#courseModal").modal("show");
            })
            .catch(error => {
                console.error("Error fetching course details:", error);
                alert("Failed to fetch course details. Please try again.");
            });
    });
});


// Employment
//======================================================================================================

// Initialize DataTables
$(document).ready(function () {
    // Initialize DataTables for Coop Table
    $('#coopTable').DataTable({
        paging: true,
        searching: true,
        ordering: true,
        pageLength: 10, // Number of rows per page
        lengthMenu: [5, 10, 25, 50], // Page size options
    });

    // Initialize DataTables for Employment Table
    $('#employmentTable').DataTable({
        paging: true,
        searching: true,
        ordering: true,
        pageLength: 10,
        lengthMenu: [5, 10, 25, 50],
    });
});
