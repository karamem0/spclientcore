import { Version } from '@microsoft/sp-core-library';
import {
    BaseClientSideWebPart,
    IPropertyPaneConfiguration,
    PropertyPaneTextField
} from '@microsoft/sp-webpart-base';
import { escape } from '@microsoft/sp-lodash-subset';

import styles from './TestApp3WebPart.module.scss';
import * as strings from 'TestApp3WebPartStrings';

export interface ITestApp3WebPartProps {
    description: string;
}

export default class TestApp3WebPart extends BaseClientSideWebPart<ITestApp3WebPartProps> {

    public render(): void {
        this.domElement.innerHTML = `
        <div class="${styles.testapp3}">
            <div class="${styles.container}">
            <div class="${styles.row}">
                <div class="${styles.column}">
                <span class="${styles.title}">Welcome to SharePoint!</span>
                <p class="${styles.subtitle}">Customize SharePoint experiences using Web Parts.</p>
                <a href="https://aka.ms/spfx" class="${styles.button}">
                    <span class="${styles.label}">Learn more</span>
                </a>
                </div>
            </div>
            </div>
        </div>`;
    }

    protected get dataVersion(): Version {
        return Version.parse('1.0');
    }

    protected getPropertyPaneConfiguration(): IPropertyPaneConfiguration {
        return {
            pages: [
            ]
        };
    }
}
