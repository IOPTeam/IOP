using System;
using System.Collections.Generic;
using System.Text;
using Api.Managers;
using Model.Models;

namespace Api.Services
{
    public class PackageService : IPackageService
    {
        private readonly IPackageManager _packageManager;

        public PackageService(IPackageManager packageManager)
        {
            _packageManager = packageManager;
        }
        
        public Parcel GetById(int id)
        {
            var package = _packageManager.GetById(id);
            if(package == default(Parcel))
            {
                throw new Exception($"Package identified as { id } not found.");
            }

            return package;
        }
    }
}
