/******************************************************************************************************
 Get item list records
******************************************************************************************************/
module.exports.listIdItem = function (req, res) {

    // build clause 
    var where = {};
    where = common.setClauseAll(req, where);
    where = common.setClauseId(req, where);
    where = extension.setClauseQuery(req.query, where);
    var attributes = ['id', 'name'];

    var extensionItem = require('./extensions/item.extension');
    var whereItem = {};
    whereItem = extensionItem.setClauseQueryView(req.query, whereItem);

    var include = [{
        model: db.item,
        where: whereItem,
        attributes: ['id', 'name', 'active', 'expired','listId', 'code', 'ruleBookId']
    }]

    db.list.findAll({
        attributes: attributes,
        where: where,
        include: include,
        order: [[db.item, "name", "asc"]],
    }).then(function (lists) {
        res.json(lists);
    }, function (err) {
        res.status(500).json(err);
    })
};