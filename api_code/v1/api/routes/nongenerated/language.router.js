
router
    .route('/dropdown')
    .get(middleware.requireAuthentication, middleware.requireAuthorisation, ctrlLanguage.getLanguagesDropdown);
