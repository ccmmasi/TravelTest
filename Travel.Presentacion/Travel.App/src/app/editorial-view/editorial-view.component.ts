import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment'; 

@Component({
  selector: 'app-editorial-view',
  templateUrl: './editorial-view.component.html',
  styleUrls: ['./editorial-view.component.css']
})
export class EditorialViewComponent implements OnInit {
 
  public paramsData: object ={
                                ID: 1,//this.ID, desde html 
                                Nombre: "Test",//this.Nombres, desde html  
                              }; 
  private ID: number = 1;

  constructor(
    private editorialViewService: EditorialViewService,
    private generales: Utilidades
  ) { }

  ngOnInit(): void {
  }

  public Editorial_ObtAll() {
    this.editorialViewService.Editorial_ObtAll().then((data) => {
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
  
  public Editorial_ObtUno(ID) {
    this.editorialViewService.Editorial_ObtUno(ID).then((data) => {
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
  
  public Editorial_Insertar(paramsData) {
    this.editorialViewService.Editorial_Insertar(paramsData).then((data) => {
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
  
  public Editorial_Actualizar(paramsData) {
    
    this.editorialViewService.Editorial_Actualizar(paramsData).then((data) => {
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
