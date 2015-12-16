angular.module('interactiveRosterApp', ['interactiveRosterApp.controllers', 'ngRoute']).
config(['$routeProvider', function($routeProvider) {
	$routeProvider.
		when('/players', {templateUrl:'/Scripts/app/rosterViewer/rosterList.html', controller: 'rosterListController'}).
		when('/players/:id', {templateUrl:'/Scripts/app/rosterViewer/playerDetail.html', controller: 'playerDetailController'}).
		otherwise({redirectTo: '/players'});
}]);

angular.module('interactiveRosterApp.controllers', ['interactiveRosterApp.services']);

angular.module('interactiveRosterApp.services', []);