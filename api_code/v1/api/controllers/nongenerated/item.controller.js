
/******************************************************************************************************
 Get a Record by Id
******************************************************************************************************/
module.exports.getListByIdItems = function (req, res) {

    // builds clause
    var where = {};
    where = common.setClauseId(req, where);
	where = common.setClauseActive(req, where);
	where = common.setClauseExpired(req.query, where); 

    var include = [{
        model: db.item, attributes: ['id', 'parentListId', 'name', 'code', 'ruleBookId']
    }];


    //find and return the records 
    db.list.findOne({
        attributes: ['id', 'name'],
        where: where,
        include: include
    }).then(function (list) {
        if (!!list) {
            res.json(list.toPublicJSON());
        } else {
            res.status(404).json({ "err": { "name": "list", "message": "An error occurred retrieving the record" } });
        }
    }, function (err) {
        res.status(500).json(err);
    })
};