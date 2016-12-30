
module.exports.setClauseExpired = function (query, where)
{

    if (query.hasOwnProperty('expired') && query.expired.length > 0)
    {
        if (query.expired == "false")
        {
            where.expired = {
                $eq: false
            };
        }
        if (query.expired == "true") {
            where.expired = {
                $eq: true
            };
        }
    }

    return where;

};