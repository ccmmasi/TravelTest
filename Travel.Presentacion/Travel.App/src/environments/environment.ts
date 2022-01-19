// This file can be replaced during build by using the `fileReplacements` array.
// `ng build` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
declare var data: any;

export const environment = {
  production: false,

  webApi: data.basePath,

  Autor_ObtAll : data.basePath + '/api/Autor/Autor_ObtAll',
  Autor_ObtUno : data.basePath + '/api/Autor/Autor_ObtUno',
  Autor_Insertar : data.basePath + '/api/Autor/Autor_Insertar',
  Autor_Actualizar : data.basePath + '/api/Autor/Autor_Actualizar',
  
  Editorial_ObtAll : data.basePath + '/api/Editorial/Editorial_ObtAll',
  Editorial_ObtUno : data.basePath + '/api/Editorial/Editorial_ObtUno',
  Editorial_Insertar : data.basePath + '/api/Editorial/Editorial_Insertar',
  Editorial_Actualizar : data.basePath + '/api/Editorial/Editorial_Actualizar',
  
  Libro_ObtAll : data.basePath + '/api/Libro/Libro_ObtAll',
  Libro_ObtUno : data.basePath + '/api/Libro/Libro_ObtUno',
  Libro_Insertar : data.basePath + '/api/Libro/Libro_Insertar',
  Libro_Actualizar : data.basePath + '/api/Libro/Libro_Actualizar',
  
  AutorLibro_ObtAll : data.basePath + '/api/AutorLibro/AutorLibro_ObtAll',
  AutorLibro_ObtUno : data.basePath + '/api/AutorLibro/AutorLibro_ObtUno',
  AutorLibro_Insertar : data.basePath + '/api/AutorLibro/AutorLibro_Insertar',
  AutorLibro_Actualizar : data.basePath + '/api/AutorLibro/AutorLibro_Actualizar',
};

/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/plugins/zone-error';  // Included with Angular CLI.
