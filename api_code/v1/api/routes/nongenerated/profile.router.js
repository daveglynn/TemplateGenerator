
router
    .route('/dropdown')
    .get(middleware.requireAuthentication, middleware.requireAuthorisation, ctrlProfile.getProfilesDropdown);
