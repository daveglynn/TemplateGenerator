router
    .route('/list/:listId')
    .get(middleware.requireAuthentication, middleware.requireAuthorisation, ctrlItem.getItemsByListId);

