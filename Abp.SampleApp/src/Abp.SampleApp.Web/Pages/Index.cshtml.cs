﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Abp.SampleApp.Web.Pages;

public class IndexModel : SampleAppPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
