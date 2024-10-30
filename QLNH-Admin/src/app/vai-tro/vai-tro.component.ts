import { Component, OnInit } from '@angular/core';
import { DataService } from '../Service/data.service';
import { VaiTro } from '../models/vai-tro.model';

@Component({
  selector: 'app-vai-tro',
  templateUrl: './vai-tro.component.html',
  styleUrls: ['./vai-tro.component.scss']
})
export class VaiTroComponent implements OnInit {
  constructor(private dataService: DataService){}

  VaiTros: VaiTro[] = [];

  ngOnInit(): void {
    this.dataService.getAllVaiTro().subscribe((data) =>{
      this.VaiTros = data;
      console.log('VaiTro:', data);
    });
  }
}
