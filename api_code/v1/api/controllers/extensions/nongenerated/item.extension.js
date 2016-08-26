
module.exports.setClauseQueryView = function (query, where)
{

    if (query.hasOwnProperty('view') && query.view.length > 0)
    {
        if (query.view == "view1")
        {
            where.active = {
                $eq: true
            };
            where.expired = {
                $eq: false
            };
        }
        if (query.view == "view2") {
            where.active = {
                $eq: true
            };
        }
    }

    return where;

};
