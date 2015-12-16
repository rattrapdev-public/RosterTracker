
angular.module('interactiveRosterApp.services').
	service('rosterService', function($http) {
		this.rosterList = function() {
			return $http.get('/api/players')
					.then(function(result) {
						return result.data;
					});
		};
	});