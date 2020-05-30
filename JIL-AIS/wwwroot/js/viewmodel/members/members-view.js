$(document).ready(function () {
    membersviewmodel.initialize();
});

var membersviewmodel = {
    initialize: function () {
        $("#menu-management").addClass('kt-menu__item--active');

        membersviewmodel.getAllMembers();
    },
    bindEvents: function () {

    }
}