import { Component, OnInit } from '@angular/core';
import { Utilidades } from '../generales/Utilidades';
import { AutorViewService } from './autor-view.service';

@Component({
  selector: 'app-autor-view',
  templateUrl: './autor-view.component.html',
  styleUrls: ['./autor-view.component.css']
})
export class AutorViewComponent implements OnInit {

  public paramsData: object ={
                                ID: 1,//this.ID, desde html 
                                Nombres: "Test",//this.Nombres, desde html 
                                Apellidos: "Test"//this.Apellidos  desde html 
                              }; 
  private ID: number = 1;

  constructor(
    private autorViewService: AutorViewService,
    private generales: Utilidades
  ) { }

  ngOnInit(): void {
  }

  public Autor_ObtAll() {
    this.autorViewService.Autor_ObtAll().then((data) => {
      const dataFinal = JSON.parse(JSON.stringify(data));
      if (dataFinal.EsExitoso) {
        const jsonResponse = JSON.parse(this.generales.$Decrypted(dataFinal.Resultado));
      } else {
        //error  
      }
    }).catch((error) => {
      //error
    });
  }
  
  public Autor_ObtUno(ID) {
    this.autorViewService.Autor_ObtUno(ID).then((data) => {
      const dataFinal = JSON.parse(JSON.stringify(data));
      if (dataFinal.EsExitoso) {
        const jsonResponse = JSON.parse(this.generales.$Decrypted(dataFinal.Resultado));
      } else {
        //error  
      }
    }).catch((error) => {
      //error
    });
  }
  
  public Autor_Insertar(paramsData) {
    this.autorViewService.Autor_Insertar(paramsData).then((data) => {
      const dataFinal = JSON.parse(JSON.stringify(data));
      if (dataFinal.EsExitoso) {
        const jsonResponse = JSON.parse(this.generales.$Decrypted(dataFinal.Resultado));
      } else {
        //error  
      }
    }).catch((error) => {
      //error
    });
  }
  
  public Autor_Actualizar(paramsData) {
    
    this.autorViewService.Autor_Actualizar(paramsData).then((data) => {
      const dataFinal = JSON.parse(JSON.stringify(data));
      if (dataFinal.EsExitoso) {
        const jsonResponse = JSON.parse(this.generales.$Decrypted(dataFinal.Resultado));
      } else {
        //error  
      }
    }).catch((error) => {
      //error
    });
  }
}
