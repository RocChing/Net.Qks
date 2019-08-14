﻿(function () {
    $(function () {
        var _table = $('#UsersTable');
        var _service = abp.services.qks.table;
        var _permissions = {
            edit: abp.auth.hasPermission('Pages.Tables.Edit'),
            'delete': abp.auth.hasPermission('Pages.Tables.Delete')
        };

        var _createOrEditModal = new app.ModalManager({
            viewUrl: abp.appPath + 'Admin/Tables/CreateOrEditModal',
            //scriptUrl: abp.appPath + 'view-resources/Areas/Admin/Views/Users/_CreateOrEditModal.js',
            modalClass: 'CreateOrEditModal'
        });

        var dataTable = _table.DataTable({
            paging: true,
            serverSide: true,
            processing: true,
            listAction: {
                ajaxFunction: _service.getList,
                inputFilter: function () {
                    return {
                        filter: $('#tableFilter').val()
                    };
                }
            },
            columnDefs: [
                {
                    className: 'control responsive',
                    orderable: false,
                    render: function () {
                        return '';
                    },
                    targets: 0
                },
                {
                    targets: 1,
                    data: null,
                    orderable: false,
                    autoWidth: false,
                    defaultContent: '',
                    rowAction: {
                        text: '<i class="fa fa-cog"></i> ' + app.localize('Actions') + ' <span class="caret"></span>',
                        items: [{
                            text: app.localize('Edit'),
                            visible: function () {
                                return _permissions.edit;
                            },
                            action: function (data) {
                                _createOrEditModal.open({ id: data.record.id });
                            }
                        }, {
                            text: app.localize('Delete'),
                            visible: function () {
                                return _permissions.delete;
                            },
                            action: function (data) {
                                //deleteUser(data.record);
                            }
                        }]
                    }
                },
                {
                    targets: 2,
                    data: "name"
                },
                {
                    targets: 3,
                    data: "namespace"
                },
                {
                    targets: 4,
                    data: "serviceName"
                },
                {
                    targets: 5,
                    data: "dtoName"
                },
                {
                    targets: 6,
                    data: "authorizeName"
                },
                {
                    targets: 7,
                    data: "getAllInputName"
                },
                {
                    targets: 8,
                    data: "createInputName"
                },
                {
                    targets: 9,
                    data: "creationTime",
                    render: function (creationTime) {
                        return moment(creationTime).format('L');
                    }
                }
            ]
        });

        function getList() {
            dataTable.ajax.reload();
        }

        $('#CreateNewButton').click(function () {
            _createOrEditModal.open();
        });

        $('#tableFilter').on('keydown', function (e) {
            if (e.keyCode !== 13) {
                return;
            }
            e.preventDefault();
            getList();
        });

        abp.event.on('app.createOrEditModalSaved', function () {
            getList();
        });
    });
})();

(function () {
    app.modals.CreateOrEditModal = function () {
        var _service = abp.services.qks.table;

        var _modalManager;
        var _form = null;

        this.init = function (modalManager) {
            _modalManager = modalManager;

            _form = _modalManager.getModal().find('form[name="saveForm"]');

            $.validator.defaults.ignore = '';

            $.validator.unobtrusive.parse(_form);

            _form.validate();

            abp.event.trigger('app.opendModal');
        }

        this.save = function () {
            if (!_form.valid()) {
                return;
            }

            var model = _form.serializeJSON({ useIntKeysAsArrayIndex: true });
 
            _modalManager.setBusy(true);
            _service.createOrUpdate(model).done(function () {
                abp.notify.info(app.localize('SavedSuccessfully'));
                _modalManager.close();
                abp.event.trigger('app.createOrEditModalSaved');
            }).always(function () {
                _modalManager.setBusy(false);
            });
        };
    }
})()