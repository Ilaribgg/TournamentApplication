// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TournamentApplication.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ilari\source\repos\TournamentApplication\TournamentApplication\Components\Tournaments.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ilari\source\repos\TournamentApplication\TournamentApplication\Components\Tournaments.razor"
using TournamentApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ilari\source\repos\TournamentApplication\TournamentApplication\Components\Tournaments.razor"
using TournamentApplication.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tournaments")]
    public partial class Tournaments : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\ilari\source\repos\TournamentApplication\TournamentApplication\Components\Tournaments.razor"
       
    Tournament selectTournament;
    string selectTournamentId;

    void SelectTournament(string tournamentId)
    {
        selectTournamentId = tournamentId;
        selectTournament = TournamentsService.GetTournaments().First(x => x.Id == tournamentId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileGamesService TournamentsService { get; set; }
    }
}
#pragma warning restore 1591