// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const targetDiv = document.getElementById("ReplyBox");
const btn = document.getElementById("ReplyButton");
btn.onclick = function () {
    if (targetDiv.style.display !== "none") {
        targetDiv.style.display = "none";
    } else {
        targetDiv.style.display = "block";
    }
};

const reportBoxDiv = document.getElementById("ReportBox");
const reportBtn = document.getElementById("ReportButton");
reportBtn.onclick = function () {
    if (reportBoxDiv.style.display !== "none") {
        reportBoxDiv.style.display = "none";
    } else {
        reportBoxDiv.style.display = "block";
    }
};

const editBoxDiv = document.getElementById("EditBox");
const editBtn = document.getElementById("EditButton");
editBtn.onclick = function () {
    if (editBoxDiv.style.display !== "none") {
        editBoxDiv.style.display = "none";
    } else {
        editBoxDiv.style.display = "block";
    }
};



