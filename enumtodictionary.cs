
            //dropdownlist for enum
            Html.DropDownList("searchKey", Enum.GetValues(typeof(SearchParams)).Cast<int>()
                .ToDictionary(e => e, e => Enum.GetName(typeof(SearchParams), e))
                .Select(x => new SelectListItem()
                {
                    Text = x.Value,
                    Value = x.Key.ToString()
                }))
