namespace Fedra.Dto.Validation
{
    public class ValidationResultDto
    {
        public List<ValidationConditionDto> Mensajes { get; set; } = new List<ValidationConditionDto>();
    }
}
