
router
    .route('/:id(\\d+)/items/')
    .get(middleware.requireAuthentication, middleware.requireAuthorisation, ctrlList.getListByIdItems);
