using learn_ca_sln.Application.Common.Models;
using Microsoft.AspNetCore.Identity;

namespace learn_ca_sln.Infrastructure.Identity;

public static class IdentityResultExtensions
{
    public static Result ToApplicationResult(this IdentityResult result)
    {
        return result.Succeeded
            ? Result.Success()
            : Result.Failure(result.Errors.Select(e => e.Description));
    }
}
