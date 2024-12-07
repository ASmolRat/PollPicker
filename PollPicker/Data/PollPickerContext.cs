using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PollPicker.Data;

namespace PollPicker.Data
{
    public class PollPickerContext(DbContextOptions<PollPickerContext> options) : IdentityDbContext<PollPickerUser>(options)
    {
    }
}
