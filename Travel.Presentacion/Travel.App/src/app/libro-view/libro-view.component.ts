import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment'; 

@Component({
  selector: 'app-libro-view',
  templateUrl: './libro-view.component.html',
  styleUrls: ['./libro-view.component.css']
})
export class LibroViewComponent implements OnInit {

  
  public paramsData: object ={
                                ISBN: 1,//this.ID, desde html 
                                Titulo: "Test",//this.Nombres, desde html  
                              }; 
  private ISBN: number = 1;

  constructor(
    private libroViewService: LibroViewService,
    private generales: Utilidades
  ) { }

  ngOnInit(): void {
  }

  public Libro_ObtAll() {
    this.libroViewService.Libro_ObtAll().then((data) => {
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
  
  public Autor_ObtUno(ISBN) {
    this.libroViewService.Libro_ObtUno(ISBN).then((data) => {
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
    this.libroViewService.Libro_Insertar(paramsData).then((data) => {
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
    
    this.libroViewService.Libro_Actualizar(paramsData).then((data) => {
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
