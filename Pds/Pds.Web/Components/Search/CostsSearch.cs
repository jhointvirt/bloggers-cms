﻿using System.Linq.Expressions;
using Calabonga.PredicatesBuilder;
using Pds.Api.Contracts.Cost;
using Pds.Core.Extensions;

namespace Pds.Web.Components.Search;

public class CostsSearch
{
    public Expression<Func<CostDto, bool>> GetSearchPredicate(string searchLine)
    {
        searchLine = searchLine.ToLower();
        var predicate = PredicateBuilder.False<CostDto>();

        predicate = predicate.Or(c => c.Id.ToShortString().Contains(searchLine));
        predicate = predicate.Or(c => c.Value.ToString("N0").Contains(searchLine));
        predicate = predicate.Or(c => c.Comment != null 
                                      && c.Comment.ToLower().Contains(searchLine));
        predicate = predicate.Or(c => !string.IsNullOrWhiteSpace(c.PaidAt.ToString("dd.MM.yyyy")) 
                                      && c.PaidAt.ToString("dd.MM.yyyy").ToLower().Contains(searchLine));

        predicate = predicate.Or(r => r.Brand != null 
                                      && r.Brand.Name != null
                                      && r.Brand.Name.ToLower().Contains(searchLine));
        predicate = predicate.Or(r => r.Content != null
                                      && r.Content.Title != null
                                      && r.Content.Title.ToLower().Contains(searchLine));
        return predicate;
    }
}