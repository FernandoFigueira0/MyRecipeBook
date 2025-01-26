using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;


namespace MyRecipeBook.Application.UseCases.User.Register;

    public class RegisterUseCase
{

    public ResponseRegisteredUserJson Execute(RequestRegisterUseJson request)
    {
        return new ResponseRegisteredUserJson
        {
            Name = request.Name,
        };
    }

    private void Validate(RequestRegisterUseJson request)
    {
        var validator = new RegisterUserValidator();

      var result =  validator.Validate(request);

        if (result.IsValid == false)
        {
            var errorMessages = result.Errors.Select(e => e.ErrorMessage);

            throw new Exception();
        }
    }

    
}


