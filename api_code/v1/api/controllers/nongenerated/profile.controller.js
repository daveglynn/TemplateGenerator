
/******************************************************************************************************
Get a Record for Dropdown
******************************************************************************************************/
module.exports.getProfilesDropdown = function (req, res) {

    // builds clause
    var where = {};

    //find and return the records 
    db.profile.findAll({
        attributes: ['id', 'parentListId', 'name', 'code', 'ruleBookId'],
        where: where
    }).then(function (profiles) {
        if (!!profiles) {
            res.json(profiles);
        } else {
            res.status(404).json({ "err": { "name": "profile", "message": "An error occurred retrieving the record" } });
        }
    }, function (err) {
        res.status(500).json(err);
    })
};
