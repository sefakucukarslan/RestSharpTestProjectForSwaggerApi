using RestSharpTestProjectForSwaggerApi.Models.Responses.pet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpTestProjectForSwaggerApi.Actions.Abstract
{
    public interface IPetActions
    {
        GetPetResponse GetPetAction(long id);
    }
}
