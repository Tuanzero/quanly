import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { MenubarModule } from 'primeng/menubar';
import { InputTextModule } from 'primeng/inputtext';
import { ButtonModule } from 'primeng/button';
import { CardModule } from 'primeng/card';
//import { SplitterModule } from 'primeng/splitter';
import { InputTextareaModule } from 'primeng/inputtextarea';
import { MessagesModule } from 'primeng/messages';
import { MessageModule } from 'primeng/message';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { ToastModule } from 'primeng/toast';
import { InputNumberModule } from 'primeng/inputnumber';
import { PanelModule } from 'primeng/panel';
import { CheckboxModule } from 'primeng/checkbox';
import { RadioButtonModule } from 'primeng/radiobutton';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NhaHangComponent } from './nha-hang/nha-hang.component';
import { VaiTroComponent } from './vai-tro/vai-tro.component';
import { HomeComponent } from './home/home.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';

@NgModule({
  declarations: [
    AppComponent,
    NhaHangComponent,
    VaiTroComponent,
    HomeComponent,
    PageNotFoundComponent
  ],
  imports: [
    AppRoutingModule,
    BrowserModule,    
    BrowserAnimationsModule,
    HttpClientModule,
    FormsModule,
    MenubarModule,
    InputTextModule,
    ButtonModule,
    CardModule,
//    SplitterModule,
    InputTextareaModule,
    MessagesModule,
    MessageModule,
    ConfirmDialogModule,
    ToastModule,
    InputNumberModule,
    PanelModule,
    CheckboxModule,
    RadioButtonModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
