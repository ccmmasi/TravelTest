import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment'; 

declare var data: any;
@Injectable()
export class AutorViewService {

  private urlService: any = environment;
  constructor(private http: HttpClient) {
  } 

  private headersCifradoBasic(): Headers {
    const myHeaders = new Headers();
    myHeaders.append('EsCifrado', 'true');
    myHeaders.append('Access-Control-Allow-Origin', '*');
    // tslint:disable-next-line:max-line-length
    myHeaders.append('Authorization', 'Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImFkbW5pc3RyYWRvciIsIlRyYW5zZmlyaWVuZG9Vc2VyIjoiYWRtbmlzdHJhZG9yIiwibmJmIjoxNjI3MTU3OTE5LCJleHAiOjE3MTcxNTc5MTksImlhdCI6MTYyNzE1NzkxOX0.t2cglgSevNBKG8kgQQKOd7hY5lMOum-YyqNJ9Fy3Qq8 ');
    return myHeaders;
  }

  private headersRestBasic(): Headers {
    const myHeaders = new Headers();
    myHeaders.append('Access-Control-Allow-Origin', '*');
    myHeaders.append('Content-Type', 'application/json');
    myHeaders.append('EsCifrado', 'false');
    myHeaders.append('Authorization', 'Basic YWRtaW5pc3RyYWRvcnRpOiFRQVp4c3cyWkzDkQ==' );
    return myHeaders;
  }

  private headersRestBasicPdf(): Headers {
    const myHeaders = new Headers();
    myHeaders.append('Access-Control-Allow-Origin', '*');
    myHeaders.append('Content-Type', 'application/pdf');
    myHeaders.append('EsCifrado', 'false');
    myHeaders.append('Authorization', 'Basic YWRtaW5pc3RyYWRvcnRpOiFRQVp4c3cyWkzDkQ==' );
    return myHeaders;
  }

  public Autor_ObtAll() {
    return new Promise((resolve) => {
      this.http.get(this.urlService.Autor_ObtAll )
        .subscribe(
          (res) => {
            resolve(res.toString());
          },
          (err: unknown) => {
            resolve(err);
          }
        );
    });
  }

  public Autor_ObtUno(paramsData) {
    return new Promise((resolve) => {
      this.http.get(this.urlService.Autor_ObtUno, paramsData )
        .subscribe(
          (res) => {
            resolve(res.toString());
          },
          (err: unknown) => {
            resolve(err);
          }
        );
    });
  }
  
  public Autor_Insertar(paramsData) {
    return new Promise((resolve) => {
      this.http.post(this.urlService.Autor_Insertar, paramsData)
        .subscribe(
          data => {
          console.log("POST Request is successful ", data);
          },
          (err: unknown) => {
            resolve(err);
          }
        );
    });
  }

  public Autor_Actualizar(paramsData) {
    return new Promise((resolve) => {
      this.http.post(this.urlService.Autor_Actualizar, paramsData )
        .subscribe(
          data => {
          console.log("POST Request is successful ", data);
          },
          (err: unknown) => {
            resolve(err);
          }
        );
    });
  }
}
