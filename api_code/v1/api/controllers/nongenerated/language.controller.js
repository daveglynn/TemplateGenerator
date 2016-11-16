
/******************************************************************************************************
 Get a Record for Dropdown
******************************************************************************************************/
module.exports.getLanguagesDropdown = function (req, res) {

    // builds clause
    var where = {};

    //find and return the records 
    db.language.findAll({
        attributes: ['id', 'parentListId', 'name', 'code', 'ruleBookId'],
        where: where
    }).then(function (languages) {
        if (!!languages) {
            res.json(languages);
        } else {
            res.status(404).json({ "err": { "name": "language", "message": "An error occurred retrieving the record" } });
        }
    }, function (err) {
        res.status(500).json(err);
    })
};