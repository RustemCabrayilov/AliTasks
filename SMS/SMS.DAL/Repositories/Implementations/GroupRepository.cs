using Microsoft.EntityFrameworkCore;
using SMS.App.Context;
using SMS.App.Models;
using SMS.App.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.App.Repositories.Implementations
{
	public class GroupRepository : GenericRepository<Group>, IGroupRepository
	{
		
	}
}
