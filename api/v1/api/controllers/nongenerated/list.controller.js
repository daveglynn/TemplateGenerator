<#+
public string getNonGeneratedItem()
{

/******************************************************************************************************
 Get item list records
******************************************************************************************************/
module.exports.listsItemsById = function(req, res) {
 
    // build clause 
    var where = {};
    where = common.setClauseAll(req, where);
    where = common.setClauseId(req, where);
    where = extension.setClauseQuery(req.query, where);
    var attributes = common.excludeAttributes();

    var include = [{
        model: db.item,
        where: { active: true },
        attributes: ['id', 'name', 'active', 'listId', 'code', 'ruleBookId'] 
    }]

    db.list.findAll({
        attributes: attributes,
        where: where,
        include: include,
        order: [[db.item, "name", "asc"]],
    }).then(function(lists) {
        res.json(lists);
    }, function(err) {
        res.status(500).json(err);
    })
};
}

#>