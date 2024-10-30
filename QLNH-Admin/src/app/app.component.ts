import { ActivatedRoute, Router, Routes } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit{
  constructor(private route: ActivatedRoute, private router: Router){}

  items: MenuItem[] = [];
  title = 'QLNH-Admin';

  ngOnInit(): void {
    this.items = [
      {
        label: 'Nhà Hàng',
        icon: 'pi pi-fw pi-home',
        command: () => this.router.navigate(['/NhaHang']),
      },
      {
        label: 'Vai Trò',
        icon: 'pi pi-fw pi-user-edit',
        command: () => this.router.navigate(['/VaiTro']),
      },
      {
        label: 'Tình Trạng',
        icon: 'pi pi-fw pi-flag',
      },
      {
        label: 'Khu Vực',
        icon: 'pi pi-fw pi-share-alt',
      },
      {
        label: 'Đơn vị',
        icon: 'pi pi-fw ??????',
      },
     ];
  }
}
