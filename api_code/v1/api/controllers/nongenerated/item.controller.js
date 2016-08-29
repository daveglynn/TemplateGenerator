/******************************************************************************************************
 Get item records
******************************************************************************************************/
module.exports.getItemsByListId = function (req, res) {

    // builds clause
    var where = {};
    where = extension.setClauseListId(req, where);
    where = extension.setClauseQueryView(req.query, where);

    var attributes = common.excludeAttributes();

    //find and return the records 
    db.item.findAll({
        attributes: attributes,
        where: where
    }).then(function (items) {
        res.json(items);
    }, function (err) {
        res.status(500).json(err);
    })
};