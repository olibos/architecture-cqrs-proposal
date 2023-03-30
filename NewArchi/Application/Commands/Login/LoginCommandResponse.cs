namespace NewArchi.Application.Commands.Login;

using OneOf;

[GenerateOneOf]
public partial class LoginCommandResponse : OneOfBase<SuccessResponse, BadCredentials>
{
    public static LoginCommandResponse BadCredentials { get; } = new BadCredentials();
}

public record BadCredentials();

public record SuccessResponse(int Id, string Fullname);