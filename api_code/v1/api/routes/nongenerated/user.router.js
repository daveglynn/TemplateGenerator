    router
    .route('/login')
    .post(ctrlUser.login);
router
    .route('/login')
    .delete(middleware.requireAuthentication, ctrlUser.logout);
