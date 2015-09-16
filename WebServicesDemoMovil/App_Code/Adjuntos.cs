using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage.Blob;

namespace WebServicesDemoMovil
{
   public class Adjuntos
    {
       public CloudBlockBlob GuardarArchivo(byte[] imagenEvento, string contenedor, string nombreImagen)
       {
           var storageAccount = Microsoft.WindowsAzure.Storage.CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
           // Create the blob client.
           var blobClient = storageAccount.CreateCloudBlobClient();
           // Retrieve a reference to a container. 
           var container = blobClient.GetContainerReference(contenedor);
           if (container.CreateIfNotExists())
           {
               container.SetPermissions(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });
           }


           var blockBlob = container.GetBlockBlobReference(string.Format("{0}{1}", DateTime.Now.ToString("ddMMyyyyhhmmss"), nombreImagen));
           try
           {
               if (imagenEvento.Count() > 0)
               {
                   blockBlob.UploadFromByteArray(imagenEvento, 0, imagenEvento.Count());
               }
           }
           catch (Exception ex)
           {
               var mensaje2 = "Error Adjuntado el archvo.";
               //    EjecutarJs(string.Format("MostrarAlerta('{0}','alerta');", mensaje2));
           }
           return blockBlob;
       }
    }
}
