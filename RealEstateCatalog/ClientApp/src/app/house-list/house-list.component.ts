import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-house-list',
  templateUrl: './house-list.component.html',
  styleUrls: ['./house-list.component.css']
})
export class HouseListComponent implements OnInit {
  public houselist: House[];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<House[]>(baseUrl + 'House/GetHouses').subscribe(result => {
      this.houselist = result;
    }, error => console.error(error));
  }

  ngOnInit() {
  }


}

interface House {
  id: number;
  address: string;
  city: string;
  state: string;
  salesPrice: number;
  squareFoot: number;
}
