import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public residents: Resident[];
  public residentialProperties: ResidentialProperty[]
  public residentialPropertiesTypes: ResidentialPropertyType[]


  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {

    http.get<Resident[]>(baseUrl + 'resident').subscribe(result => {
      this.residents = result;
    }, error => console.error(error));

    http.get<ResidentialProperty[]>(baseUrl + 'residentialProperty').subscribe(result => {
      this.residentialProperties = result;
    }, error => console.error(error));

    http.get<ResidentialPropertyType[]>(baseUrl + 'residentialPropertyType').subscribe(result => {
      this.residentialPropertiesTypes = result;
    }, error => console.error(error));
  }

  updateResident(resident) {
    this.http.put<Resident>(this.baseUrl + 'resident', resident)
      .subscribe(result => {
      }, error => console.error(error));  }


  deleteResident(id) {
    this.http.delete<Resident[]>(this.baseUrl + 'resident').subscribe(result => {
    }, error => console.error(error));
  }

  updateResidentialProperty(resident) {
    this.http.put<ResidentialProperty>(this.baseUrl + 'residentialProperty', resident)
      .subscribe(result => {
      }, error => console.error(error));
  }


  deleteResidentProperty(id) {
    this.http.delete<ResidentialProperty[]>(this.baseUrl + 'residentialProperty').subscribe(result => {
    }, error => console.error(error));
  }
}

interface Resident {
  id: number;
  firstName: number;
  lastName: number;
  residentialProperty: ResidentialProperty
}

interface ResidentialProperty {
  id: number;
  price: number;
  bedrooms: number;
  residentialPropertyType: ResidentialPropertyType
}

interface ResidentialPropertyType {
  id: number;
  type: string;
}
