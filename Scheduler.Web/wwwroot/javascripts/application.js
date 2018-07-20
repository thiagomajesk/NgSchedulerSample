/*****************************************************************************************************************
* Bootstrap
*****************************************************************************************************************/
var app = angular.module('SchedulerApp', ['ngMaterial', 'ngMessages', 'material.svgAssetsCache']);

app.controller('AppController', ['$rootScope', '$scope', '$filter', '$http', AppController]);

/*****************************************************************************************************************
* AppController
*****************************************************************************************************************/
function AppController($rootScope, $scope, $filter, $http) {

    this.$onInit = initialize;

    $scope.$watch('selectedDate', onSelectedDateChange);

    function initialize() {
        $scope.selectedDate = new Date();
        $scope.appointmentList = [];
        $scope.appointment = {};
        $scope.patientNames = ['John MacYver', 'Mary Madsen', 'Robert Bolton', 'Rick Harrington'];
        $scope.createAppointment = createAppointment;
        $scope.deleteAppointment = deleteAppointment;
        $scope.setEditing = setEditing;
        $scope.isEditing = isEditing;
        $scope.cancelEditing = cancelEditing;
        $scope.manageAppointment = manageAppointment;
    }

    function showErrorMessage(title, message) {
        toastr.error(message, title);
    }

    function showSuccesMessage(title, message) {
        toastr.success(message, title);
    }

    function listAppointments(date) {
        $http.get(window.location.origin + '/appointment/list' + '?date=' + date, {}).then(onListSuccess, onListError);
    }

    function onListSuccess(response) {
        if (response.data.length > 0) $scope.appointmentList = response.data;
        else $scope.appointmentList = [];
    }

    function onListError(error) {
        var title = 'Something wrong happened';
        var message = 'An error ocurred while listing the appointments';
        showErrorMessage(title, message);
    }

    function onSelectedDateChange() {
        listAppointments($scope.selectedDate.toISOString());
    }

    function manageAppointment(appointment) {
        if (isEditing(appointment)) {
            editAppointment(appointment);
        } else {
            createAppointment(appointment);
        }
    }

    function createAppointment(appointment) {
        var newAppointment = {};

        patchDates(appointment, function (startDate, endDate) {
            newAppointment.patientName = appointment.patientName;
            newAppointment.patientBirthdate = appointment.patientBirthdate;
            newAppointment.remarks = appointment.remarks;
            newAppointment.startDate = startDate.format('MM/DD/YYYY HH:mm:ss');
            newAppointment.endDate = endDate.format('MM/DD/YYYY HH:mm:ss');
        });

        $http.post(window.location.origin + '/appointment/create', newAppointment)
            .then(onCreatedSuccess, onCreatedError);
    }

    function patchDates(appointment, callback) {
        var date = moment($scope.selectedDate);
        var time = moment(appointment.time);

        var year = date.year();
        var month = date.month();
        var day = date.day();
        var hour = time.hour();
        var minute = time.minute();

        // Always creates an appointment within the 40 minutes range
        var startDate = moment().year(year).month(month).day(day).hour(hour).minute(minute);
        var endDate = moment(startDate).add(40, 'minutes');

        callback(startDate, endDate)
    }

    function onCreatedSuccess(response) {
        var appointment = response.data;
        $scope.appointmentList.push(appointment);
        var title = 'Success';
        var message = 'A new appointment was created';
        showSuccesMessage(title, message);
    }

    function onCreatedError(error) {
        var title = 'Error';
        var message = 'Could not create a new appointment.' + error.data;
        showErrorMessage(title, message);
    }

    function deleteAppointment(appointment) {
        $http.delete(window.location.origin + '/appointment/delete' + '?id=' + appointment.id)
            .then(function () { onDeletedSuccess(appointment) }, onDeletedError);
    }

    function onDeletedSuccess(appointment) {
        $scope.appointmentList = $scope.appointmentList.filter(function (ap) {
            return ap.id != appointment.id
        });

        var title = 'Success';
        var message = 'The appointment was deleted';
        showSuccesMessage(title, message);
    }

    function onDeletedError() {
        var title = 'Error';
        var message = 'Could not delete appointment';
        showErrorMessage(title, message);
    }

    function setEditing(appointment) {
        appointment.editing = true;
        appointment.startDate = new Date(appointment.startDate);
        appointment.endDate = new Date(appointment.endDate);
        appointment.patientBirthdate = new Date(appointment.patientBirthdate);
        $scope.appointment = appointment;
    }

    function cancelEditing(appointment) {
        appointment.editing = false;
        $scope.appointment = {};
    }

    function isEditing(appointment) {
        return appointment.id > 0 && appointment.editing;
    }

    function editAppointment(appointment) {

        patchDates(appointment, function (startDate, endDate) {
            appointment.startDate = startDate.format('MM/DD/YYYY HH:mm:ss');
            appointment.endDate = endDate.format('MM/DD/YYYY HH:mm:ss');
        });

        $http.post(window.location.origin + '/appointment/update', appointment)
            .then(function () { onUpdatedSuccess(appointment) }, onUpdatedError);
    }

    function onUpdatedSuccess(appointment) {
        cancelEditing(appointment);
        var title = 'Success';
        var message = 'The appointment was updated';
        showSuccesMessage(title, message);
    }

    function onUpdatedError(error) {
        var title = 'Error';
        var message = 'Could not update appointment.' + + error.data;
        showErrorMessage(title, message);
    }
}