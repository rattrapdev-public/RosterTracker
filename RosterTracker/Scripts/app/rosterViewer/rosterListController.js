angular.module('interactiveRosterApp.controllers').controller('rosterListController', function ($scope, rosterService) {
	rosterService.rosterList().then(function(data) {
		$scope.roster = data;
		console.log(data);
	});
});